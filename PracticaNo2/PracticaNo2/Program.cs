using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PracticaNo2\n\n" +
                "0- Fracción mixta a impropia\n" +
                "1- Números primos\n" +
                "2- MCM y MCD\n" +
                "3- Suma y diferencia de cubo\n" +
                "4- Palíndromo\n" +
                "5- Invierte las palabras\n" +
                "6- Lotería de tres números\n" +
                "7- Año biciesto\n" +
                "8- Cantidad de semanas entre fechas indicadas\n" +
                "9- Torre de hanoi\n" +
                "10- Método de burbuja\n");
            Console.Write("\nElige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Realizar programa que realice conversión de fracciones mixtas a fracciones comunes");
                    Console.Write("\nDigite el número entero de la fracción mixta: ");
                    int mixta = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite el numerador de la fracción mixta: ");
                    int numerador = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite el denominador de la fracción mixta: ");
                    int denominador = Convert.ToInt32(Console.ReadLine());
                    int impropia = (mixta * denominador) + numerador;
                    Console.WriteLine($"\nLa conversión a impropia es: {impropia}/{denominador}");
                    break;

                case 1:
                    Console.WriteLine("Realizar programa imprima los números primos desde un numero inicial hasta un numero final definido");
                    Console.Write("\nDigite un número final: ");
                    int primoFinal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nEl número 2 es primo");
                    Console.WriteLine("El número 3 es primo");
                    Console.WriteLine("El número 5 es primo");
                    Console.WriteLine("El número 7 es primo");
                    Console.WriteLine("El número 11 es primo");
                    int[] primo = new int[primoFinal];
                    int indicePrimo = 0;
                    int residuoPrimo = 2;
                    do
                    {
                        for (int i = 2; i < primoFinal; i++)
                        {
                            if (i % residuoPrimo != 0)
                            {
                                primo[indicePrimo] = i;
                                indicePrimo++;
                            }
                        }
                        residuoPrimo++;
                    } while (residuoPrimo == 7);
                    for (int i = 0; i < primo.Length; i++)
                    {
                        if (primo[i] != 0 && primo[i] % 2 != 0 && primo[i] % 3 != 0 && primo[i] % 5 != 0 && primo[i] % 7 != 0 && primo[i] % 11 != 0)
                        {
                            Console.WriteLine($"El número {primo[i]} es primo");
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Realizar programa que determine el MCD y MCM");
                    Console.Write("\nDigite el primer número: ");
                    int primerNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite el segundo número: ");
                    int segundoNum = Convert.ToInt32(Console.ReadLine());
                    int mcm = 0;
                    int mcd = 0;
                    if (primerNum != 0 || segundoNum != 0)
                    {
                        for (int i = 1; i <= Math.Min(primerNum, segundoNum); i++)
                        {
                            if (primerNum % i == 0 && segundoNum % i == 0)
                            {
                                mcd = i;
                                mcm = (primerNum * segundoNum) / mcd;
                            }
                        }
                        Console.WriteLine($"\nMCM= {mcm}\nMCD= {mcd}");
                    }
                    else
                    {
                        Console.WriteLine("El número no puede ser 0!!!");
                    }
                    break;

                case 3:
                    Console.WriteLine("Realizar programa que resuelva sumas o diferencia de cubos");
                    Console.Write("\nDigite el entero de x^3: ");
                    double x3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite el entero de y^3: ");
                    double y3 = Convert.ToDouble(Console.ReadLine());
                    if (x3 != 0 && y3 != 0)
                    {
                        double raizX3 = Math.Pow(x3, 1.0 / 3.0);
                        double raizY3 = Math.Pow(y3, 1.0 / 3.0);
                        double potenciaX3 = Math.Pow(raizX3, 2);
                        double potenciaY3 = Math.Pow(raizY3, 2);
                        double xPorY = raizX3 * raizY3;

                        Console.WriteLine($"\nSuma de cubo: ({raizX3}x + {raizY3}y)({potenciaX3}x² - {xPorY}xy + {potenciaY3}y²)");
                        Console.WriteLine($"Resta de cubo: ({raizX3}x - {raizY3}y)({potenciaX3}x² + {xPorY}xy + {potenciaY3}y²)");
                    }
                    break;

                case 4:
                    Console.WriteLine("Realizar programa que determine si una cadena de texto es un pálindromo");
                    Console.Write("\nDigite una cadena: ");
                    string palindromo = Console.ReadLine();
                    int len = palindromo.Length;
                    string reverse = "";
                    string caracter;
                    for (int i = len - 1; i >= 0; i--)
                    {
                        caracter = palindromo.Substring(i, 1);
                        reverse += caracter;
                    }
                    if (palindromo == reverse)
                    {
                        Console.WriteLine("\nEs palindromo");
                    }
                    else
                    {
                        Console.WriteLine("\nNo es palindromo");
                    }
                    break;

                case 5:
                    Console.WriteLine("Realizar programa que que invierta el sentido de las palabras");
                    Console.Write("\nDigite una cadena: ");
                    string invierta = Console.ReadLine();
                    int tamaño = invierta.Length;
                    string reversa = "";
                    string character;
                    for (int i = tamaño - 1; i >= 0; i--)
                    {
                        character = invierta.Substring(i, 1);
                        reversa += character;
                    }
                    Console.WriteLine($"\nPalabra invertida: {reversa}");
                    break;

                case 6:
                    Console.WriteLine("Realizar programa que simule una tombola de lotería nacional y selecione tres números aleatorios");
                    Random random = new Random();
                    int numAleatorio1 = random.Next(1, 30);
                    int numAleatorio2 = random.Next(31, 60);
                    int numAleatorio3 = random.Next(61, 90);
                    Console.WriteLine($"\nPrimer número de la lotería: {numAleatorio1}\nSegundo número de la lotería: {numAleatorio2}\nTercer número de la lotería: {numAleatorio3}");
                    break;

                case 7:
                    Console.WriteLine("Realizar programa que calcule e indique si un año es biciesto o no");
                    Console.Write("\nDigite año que desea comprobar: ");
                    int año = Convert.ToInt16(Console.ReadLine());
                    int bisiesto = año % 4;
                    if (bisiesto == 0)
                    {
                        Console.WriteLine($"\nEl año {año} es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine($"\nEl año {año} no es bisiesto");
                    }
                    break;

                case 8:
                    Console.WriteLine("Realizar programa que Calcule las cantidades de Semanas entre dos fechas introducidas por teclado");
                    Console.Write("\nDigite una fecha inicial: ");
                    DateTime dateTimeInicial = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Digite una fecha final: ");
                    DateTime dateTimeFinal = Convert.ToDateTime(Console.ReadLine());
                    TimeSpan dateTimeTotal = dateTimeFinal.Subtract(dateTimeInicial);
                    double dias = dateTimeTotal.TotalDays;
                    double semanas = dias / 7;
                    double diasSemana = dias % 7;
                    Console.WriteLine($"\n{Math.Round(semanas, 0)} semanas y {diasSemana} días");
                    break;

                case 9:
                    Console.WriteLine("Realizar programa que despligue la torre de hanoi");
                    Console.Write("\nDigite cantidad de discos: ");
                    double discos = Convert.ToInt16(Console.ReadLine());
                    double movimientos = Math.Pow(2, discos) - 1;
                    Console.WriteLine($"\nCantidad de movimientos a realizar: {movimientos} movimientos");
                    break;

                case 10:
                    Console.WriteLine("Realizar programa que genere números aleatorios en un arreglo y luego este mismo arreglo sea ordenado por metodo de la burbuja de manera descendente y ascendente");
                    Random random1 = new Random();
                    int temp;
                    Console.Write("\nDigite cantidad de números aleatorios a generar: ");
                    int cantidadNumerosAleatorios = Convert.ToInt32(Console.ReadLine());
                    int[] arregloAleatorio = new int[cantidadNumerosAleatorios];
                    for (int i = 0; i < arregloAleatorio.Length; i++)
                    {
                        int burbujaAleatorio = random1.Next(1, 100);
                        arregloAleatorio[i] = burbujaAleatorio;
                    }
                    for (int i = 1; i < arregloAleatorio.Length; i++)
                    {
                        for (int j = arregloAleatorio.Length - 1; j >= i; j--)
                        {
                            if (arregloAleatorio[j - 1] > arregloAleatorio[j])
                            {
                                temp = arregloAleatorio[j - 1];
                                arregloAleatorio[j - 1] = arregloAleatorio[j];
                                arregloAleatorio[j] = temp;
                            }
                        }
                    }
                    int menos = arregloAleatorio.Length - 1;
                    Console.WriteLine("\nArreglo ordenado ascendentemente: ");
                    for (int i = 0; i < arregloAleatorio.Length; i++)
                    {
                        Console.Write($"{arregloAleatorio[i]}  ");
                    }
                    Console.WriteLine("\n\nArreglo ordenado descendentemente: ");
                    while (menos != -1)
                    {
                        Console.Write($"{arregloAleatorio[menos]}  ");
                        menos--;
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida!!!");
                    break;
            }


            Console.ReadKey();
        }
    }
}
