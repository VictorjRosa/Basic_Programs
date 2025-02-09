using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNo1
{
    internal class Practica1
    {
        static void Main(string[] args)
        {
            Console.Write("Practica No.1!!!\n" +
                "\n0- Factorial de un número" +
                "\n1- Serie fibonacci" +
                "\n2- El area del cuadrado, círculo, triángulo, pentágono y hexágono" +
                "\n3- El volumen del cubo, esfera, cono y pirámide" +
                "\n4- Funciones trigonométricas" +
                "\n5- Operaciones con fracciones" +
                "\n6- Permutaciones con repetición y sin repetición" +
                "\n7- Combinaciones con repetición y sin repetición" +
                "\n8- Ecuaciones de segundo grado con la formula general" +
                "\n9- Calculo de velocidad, tiempo y distancia" +
                "\n10- Conversión de temperaturas ºC, ºK y ºF" +
                "\n11- Promedio de calificación Unphu" +
                "\n12- Desglose de billetes y monedas de una cantidad" +
                "\n13- Salario neto" +
                "\n14- Ecuaciones lineales de primer grado" +
                "\n\nElige una opción: ");
            int opcion = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 0:
                    int n = 1;
                    Console.WriteLine("Realizar programa que despligue el factorial de número.");
                    Console.Write("\nDigite un número a factoriar: ");
                    int factorial = Convert.ToInt32(Console.ReadLine());
                    if (factorial < 0)
                    {
                        Console.WriteLine("No existe el factorial de un numero negativo!!!");
                    }
                    else
                    {
                        for (int i = 1; i <= factorial; i++)
                        {
                            n *= i;
                            if (i < factorial)
                            {
                                Console.Write($"{i}x");
                            }
                            else
                            {
                                Console.Write($"{i}= {n}");
                            }
                        }
                    }
                    break;
                case 1:
                    int temporal;
                    Console.WriteLine("Realizar programa que despliegue la serie fibonacci desde un número hasta un límite definido");
                    Console.Write("\nDigite primer número: ");
                    int fibonacci1= Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite segundo número: ");
                    int fibonacci2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{fibonacci1}, ");
                    for (int i = 0; i < 15; i++)
                    {
                        if (i < 14)
                        {
                            temporal = fibonacci1;
                            fibonacci1 = fibonacci2;
                            fibonacci2 = temporal + fibonacci1;
                            Console.Write($"{fibonacci1}, ");
                        }
                        else
                        {
                            temporal = fibonacci1;
                            fibonacci1 = fibonacci2;
                            fibonacci2 = temporal + fibonacci1;
                            Console.Write(fibonacci1);
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Realizar programa que calcule las áreas de las figuras geométricas cuadrado, círculo, triángulo, pentágono, hexágono");
                    Console.Write("\n1- Cuadrado\t2- Círculo\t3- Triángulo\t4- Pentágono\t5- Hexágono\n\nElige una opción: ");
                    int figuraA = Convert.ToInt16(Console.ReadLine());
                    switch (figuraA)
                    {
                        case 1:
                            Console.Write("\nDigite la longitud de un lado del cuadrado: ");
                            double cuadrado = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El área del cuadrado es igual a: {Math.Round(Math.Pow(cuadrado,2))} m²");
                            break;
                        case 2:
                            Console.Write("\nDigite el radio del círculo: ");
                            double radioCirculo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El área del círculo es igual a: {Math.Round(Math.PI * Math.Pow(radioCirculo, 2),2)} m²");
                            break;
                        case 3:
                            Console.Write("\nDigite la base del triángulo: ");
                            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite la altura del triángulo: ");
                            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El área del triángulo es igual a: {Math.Round((baseTriangulo * alturaTriangulo) / 2, 2)} m²");
                            break;
                        case 4:
                            Console.Write("\nDigite la longitud de un lado del pentágono: ");
                            double longitudPentagono = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite la apotema del pentágono: ");
                            double apotemaPentagono = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El área del pentágono es igual a: {Math.Round((((5*longitudPentagono)*apotemaPentagono)/2),2)} m²");
                            break;
                        case 5:
                            Console.Write("\nDigite la longitud de un lado del hexágono: ");
                            double longitudHexagono = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite la apotema del hexágono: ");
                            double apotemaHexagono = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El área del hexágono es igual a: {Math.Round((((6 * longitudHexagono) * apotemaHexagono) / 2), 2)} m²");
                            break;
                        default:
                            Console.WriteLine("La opción no es válida!!!");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Realizar programa que calcule el volumen de las figuras geométricas cubo, esfera, cono y pirámide");
                    Console.Write("\n1- Cubo\t2- Esfera\t3- Cono\t4- Pirámide\n\nElige una opción: ");
                    int figuraV = Convert.ToInt16(Console.ReadLine());
                    switch (figuraV)
                    {
                        case 1:
                            Console.Write("\nDigite la longitud de un lado del cubo: ");
                            double cubo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El volumen del cubo es igual a: {Math.Round(Math.Pow(cubo, 3),2)} m^3");
                            break;
                        case 2:
                            Console.Write("\nDigite el radio de la esfera: ");
                            double radioEsfera = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El volumen de la esfera es igual a: {Math.Round((4*(Math.PI * Math.Pow(radioEsfera, 3))) / 3, 2)} m^3");
                            break;
                        case 3:
                            Console.Write("\nDigite el radio del cono: ");
                            double radioCono = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite la altura del cono: ");
                            double alturaCono = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El volumen del cono es igual a: {Math.Round((Math.PI * Math.Pow(radioCono, 2) * alturaCono) / 3, 2)} m^3");
                            break;
                        case 4:
                            Console.Write("\nDigite la longitud base de la pirámide: ");
                            double basePiramide = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite la longitud ancho de la pirámide: ");
                            double anchoPiramide = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite la altura de la piramide: ");
                            double alturaPiramide = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El volumen de la pirámide es igual a: {Math.Round((basePiramide * anchoPiramide * alturaPiramide) / 3, 2)} m^3");
                            break;
                        default:
                            Console.WriteLine("La opción no es válida!!!");
                            break;
                    }
                    break;
                
                case 4:
                    Console.WriteLine("Realizar programa que calcule las funciones trigonométricas, seno, coseno, secante, cosecante, tangente, cotangente");
                    Console.Write("\nDigite un número: ");
                    double trigonometria = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Seno: {Math.Sin(trigonometria)}\n" +
                        $"Coseno: {Math.Cos(trigonometria)}\n" +
                        $"Tangente: {Math.Tan(trigonometria)}\n" +
                        $"Cotangente: {Math.Cos(trigonometria)/Math.Sin(trigonometria)}\n" +
                        $"Secante: {1/Math.Cos(trigonometria)}\n" +
                        $"Cosecante: {1/Math.Sin(trigonometria)}");
                    break;

                case 5:
                    Console.WriteLine("Realizar programa que realice operaciones con fracciones,las operaciones a realizar son suma, resta, multiplicación, división");
                    Console.Write("\n1- Suma\t2- Resta\t3- Multiplicación\t4- División\n\nElige una opción: ");
                    int fraccion = Convert.ToInt16(Console.ReadLine());
                    switch (fraccion)
                    {
                        case 1:
                            Console.Write("\nDigite numerador primer número: ");
                            int sumaNum1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite denominador primer número: ");
                            int sumaDen1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite numerador segundo número: ");
                            int sumaNum2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite denominador segundo número: ");
                            int sumaDen2 = Convert.ToInt32(Console.ReadLine());
                            int sumaTotal = sumaNum1 + sumaNum2;
                            int sumaResiduo = sumaTotal % sumaDen1;
                            if(sumaDen1 != 0 && sumaDen2 != 0)
                            {
                                if (sumaDen1 != sumaDen2)
                                {
                                    Console.Write($"La suma de las fracciones es igual a: {(sumaNum1 / sumaDen1) + (sumaNum2 / sumaDen2)}");
                                }
                                else
                                {
                                    if (sumaResiduo != 0)
                                    {
                                        Console.Write($"La suma de las fracciones es igual a: {sumaTotal}/{sumaDen1}");
                                    }
                                    else
                                    {
                                        Console.Write($"La suma de las fracciones es igual a: {sumaTotal/sumaDen1}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor indefinido, el denominador no puede ser 0!!!");
                            }
                            break;
                        case 2:
                            Console.Write("\nDigite numerador primer número: ");
                            int restaNum1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite denominador primer número: ");
                            int restaDen1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite numerador segundo número: ");
                            int restaNum2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite denominador segundo número: ");
                            int restaDen2 = Convert.ToInt32(Console.ReadLine());
                            int restaTotal = restaNum1 - restaNum2;
                            int restaResiduo = restaTotal % restaDen1;
                            if (restaDen1 != 0 && restaDen2 != 0)
                            {
                                if (restaDen1 != restaDen2)
                                {
                                    Console.Write($"La resta de las fracciones es igual a: {(restaNum1 / restaDen1) - (restaNum2 / restaDen2)}");
                                }
                                else
                                {
                                    if (restaResiduo != 0)
                                    {
                                        Console.Write($"La resta de las fracciones es igual a: {restaTotal}/{restaDen1}");
                                    }
                                    else
                                    {
                                        Console.Write($"La resta de las fracciones es igual a: {restaTotal/restaDen1}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor indefinido, el denominador no puede ser 0!!!");
                            }
                            break;
                        case 3:
                            Console.Write("\nDigite numerador primer número: ");
                            int multNum1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite denominador primer número: ");
                            int multDen1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite numerador segundo número: ");
                            int multNum2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite denominador segundo número: ");
                            int multDen2 = Convert.ToInt32(Console.ReadLine());
                            int multNumTotal = multNum1 * multNum2;
                            int multDenTotal = multDen1 * multDen2;
                            int multResiduo = multNumTotal % multDenTotal;
                            if (multDen1 != 0 && multDen2 != 0)
                            {
                                if (multResiduo != 0)
                                {
                                    Console.Write($"La multiplicación de las fracciones es igual a: {multNumTotal}/{multDenTotal}");
                                }
                                else
                                {
                                    Console.Write($"La multiplicación de las fracciones es igual a: {(multNumTotal) /(multDenTotal)}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor indefinido, el denominador no puede ser 0!!!");
                            }
                            break;
                        case 4:
                            Console.Write("\nDigite numerador primer número: ");
                            int divNum1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite denominador primer número: ");
                            int divDen1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite numerador segundo número: ");
                            int divNum2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite denominador segundo número: ");
                            int divDen2 = Convert.ToInt32(Console.ReadLine());
                            int divNumTotal = divNum1 * divDen2;
                            int divDenTotal = divNum2 * divDen1;
                            int divResiduo = divNumTotal % divDenTotal;
                            if (divDen1 != 0 && divDen2 != 0)
                            {
                                if (divResiduo != 0)
                                {
                                    Console.Write($"La división de las fracciones es igual a: {divNumTotal}/{divDenTotal}");
                                }
                                else
                                {
                                    Console.Write($"La división de las fracciones es igual a: {(divNumTotal) / (divDenTotal)}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor indefinido, el denominador no puede ser 0!!!");
                            }
                            break;
                        default:
                            Console.Write("\nOpción no válida!!!");
                            break;
                    }
                    break;

                case 6:
                    Console.WriteLine("Realizar programa que calcule permutaciones basado datos entrados por teclado, con repetición y sin repetición.");
                    int k = 1;
                    int k1= 1;
                    int k2 = 1;
                    int k3 = 1;
                    Console.Write("\nCantidad a permutar: ");
                    int sinRepeticion = Convert.ToInt32(Console.ReadLine());
                    if (sinRepeticion < 0)
                    {
                        Console.WriteLine("No existe el factorial de un numero negativo!!!");
                    }
                    else
                    {
                        for (int i = 1; i <= sinRepeticion; i++)
                        {
                            k *= i;
                        }
                        for (int i = 1; i <= 2; i++)
                        {
                            k2 *= i;
                        }
                        for (int i = 1; i <= 3; i++)
                        {
                            k3 *= i;
                        }
                    }
                    Console.WriteLine($"La cantidad de permutaciones sin repeticiones es: {k}\nLa cantidad de permutaciones con repeticiones es: {k / ((k1)*(k2)*(k3))}");
                        break;

                case 7:
                    Console.WriteLine("Realizar programa que calcule combinaciones basado en datos entrados por teclados con repetición y sin repeticiones.");
                    double c = 1; //Conjuntos
                    double e = 1; //Elementos
                    double ce = 1; //Conjuntos - Elementos
                    double cem = 1; //Conjuntos + Elementos - 1
                    double cm = 1; //Conjuntos - 1
                    Console.Write("\nDigite el número de conjuntos: ");
                    int conjuntos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite el número de elementos: ");
                    double elementos = Convert.ToInt32(Console.ReadLine());
                    double conjElem = conjuntos - elementos;
                    double conjElemMenos = (conjuntos + elementos - 1);
                    double conj = conjuntos - 1;
                    if (conjuntos < 0)
                    {
                        Console.WriteLine("No existe el factorial de un número negativo!!!");
                    }
                    else
                    {
                        for (int i = 1; i <= conjuntos; i++)
                        {
                            c *= i;
                        }
                    }
                    if (elementos < 0)
                    {
                        Console.WriteLine("No existe el factorial de un número negativo!!!");
                    }
                    else
                    {
                        for (int i = 1; i <= elementos; i++)
                        {
                            e *= i;
                        }
                    }
                    if (conjElem < 0)
                    {
                        Console.WriteLine("No existe el factorial de un número negativo!!!");
                    }
                    else
                    {
                        for (int i = 1; i <= conjElem; i++)
                        {
                            ce *= i;
                        }
                    }
                    if (conjElemMenos < 0)
                    {
                        Console.WriteLine("No existe el factorial de un número negativo!!!");
                    }
                    else
                    {
                        for (int i = 1; i <= conjElemMenos; i++)
                        {
                            cem *= i;
                        }
                    }
                    if (conj < 0)
                    {
                        Console.WriteLine("No existe el factorial de un número negativo!!!");
                    }
                    else
                    {
                        for (int i = 1; i <= conj; i++)
                        {
                            cm *= i;
                        }
                    }
                    Console.WriteLine($"\nLa cantidad de combinaciones sin repetición son: {c / (e * (ce))}");
                    Console.WriteLine($"\nLa cantidad de combinaciones con repetición son: {cem / (e * (cm))}");
                    break;

                case 8:
                    Console.WriteLine("Realizar programa que resuelva ecuaciones de segundo grado con la formula general.");
                    Console.Write("\nDigite el número de x²: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite el número de x: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite el número independiente: ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"El resultado de x1: {(-b+(Math.Sqrt(Math.Pow(b,2)-(4*a*d))))/(2*a)}\nEl resultado de x2: {(-b - (Math.Sqrt(Math.Pow(b, 2) - (4 * a * d)))) / (2 * a)}");
                    break;

                case 9:
                    Console.WriteLine("Realizar programa que utilizando las formulas de física calcule velocidad, tiempo y distancia basado en dos de estos datos introducidos por teclado.");
                    Console.Write("\n1- Velocidad\t2- Tiempo\t3- Distancia\n\nElige una opción: ");
                    int fisica = Convert.ToInt16(Console.ReadLine());
                    switch (fisica)
                    {
                        case 1:
                            Console.Write("\nDigite la distancia: ");
                            double distancia1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite el tiempo: ");
                            double tiempo1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"La velocidad es igual a: {distancia1/tiempo1} m/s");
                            break;
                        case 2:
                            Console.Write("\nDigite la distancia: ");
                            double distancia2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite la velocidad: ");
                            double velocidad2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El tiempo es igual a: {distancia2 / velocidad2} s");
                            break;
                        case 3:
                            Console.Write("\nDigite la velocidad: ");
                            double velocidad3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite el tiempo: ");
                            double tiempo3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"La distancia es igual a: {velocidad3 * tiempo3} m");
                            break;
                        default:
                            Console.WriteLine("Opción no válida!!!");
                            break;
                    }
                    break;

                case 10:
                    Console.WriteLine("Realizar programa que realice conversión de temperaturas celsius, kelvins, fahrenheit");
                    Console.Write("\n1-Para convertir de ºC a ºF\n" +
                        "2-Para convertir de ºF a ºC\n" +
                        "3-Para convertir de ºK a ºC\n" +
                        "4-Para convertir de ºC a ºK\n" +
                        "5-Para convertir de ºF a ºK\n" +
                        "6-Para convertir de ºK a ºF\n\nElige una opción: ");
                        int temperatura = Convert.ToInt16(Console.ReadLine());
                    switch (temperatura)
                    {
                        case 1:
                            Console.Write("\nDigite la temperatura celcius: ");
                            int celsius1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"La temperatura en fahrenheit es igual a: {(celsius1*1.8)+32}");
                            break;
                        case 2:
                            Console.Write("\nDigite la temperatura fahrenheit: ");
                            int fahrenheit2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"La temperatura en celsius es igual a: {(fahrenheit2 - 32) / 1.8}");
                            break;
                        case 3:
                            Console.Write("\nDigite la temperatura kelvins: ");
                            int kelvins3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"La temperatura en celsius es igual a: {kelvins3 - 273.15}");
                            break;
                        case 4:
                            Console.Write("\nDigite la temperatura celsius: ");
                            int celsius4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"La temperatura en kelvins es igual a: {celsius4 + 273.15}");
                            break;
                        case 5:
                            Console.Write("\nDigite la temperatura fahrenheit: ");
                            int fahrenheit5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"La temperatura en kelvins es igual a: {((5 * (fahrenheit5 - 32))/9) + 273.15}");
                            break;
                        case 6:
                            Console.Write("\nDigite la temperatura kelvins: ");
                            int kelvins6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"La temperatura en fahrenheit es igual a: {1.8 * (kelvins6 - 273.15) + 32}");
                            break;
                        default:
                            Console.WriteLine("Opción no válida!!!");
                            break;
                    }
                    break;

                case 11:
                    Console.WriteLine("Realizar un programa que calcule la calificación promedio basado en un conjunto de calificaciones introducidas por teclado e indique el literal correspondiente.");
                    Console.Write("\nDigite nota primer parcial: ");
                    int pp1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite nota segundo parcial: ");
                    int pp2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite nota práctica: ");
                    int tp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite nota examen final: ");
                    int ef = Convert.ToInt32(Console.ReadLine());
                    int notaFinal = (((pp1 + pp2)/2) + tp + ef) / 3;
                    if (notaFinal >= 90 && tp >=70 && ef >= 55)
                    {
                        Console.WriteLine($"Su nota final es: {notaFinal}\t-\tLiteral: A");
                    }
                    else
                    {
                        if (notaFinal >= 80 && notaFinal < 90 && tp >= 70 && ef >= 55)
                        {
                            Console.WriteLine($"Su nota final es: {notaFinal}\t-\tLiteral: B");
                        }
                        else
                        {
                            if (notaFinal >= 70 && notaFinal < 80 && tp >= 70 && ef >= 55)
                            {
                                Console.WriteLine($"Su nota final es: {notaFinal}\t-\tLiteral: C");
                            }
                            else
                            {
                                if (notaFinal >= 60 && notaFinal < 70 && tp >= 70 && ef >= 55)
                                {
                                    Console.WriteLine($"Su nota final es: {notaFinal}\t-\tLiteral: D");
                                }
                                else
                                {
                                    if (tp < 70)
                                    {
                                        Console.WriteLine($"Su nota final es: {notaFinal}\t-\tLiteral: F\nReprobado por no cumplir la nota mínima de práctica!!!");
                                    }
                                    else
                                    {
                                        if (ef < 55)
                                        {
                                            Console.WriteLine($"Su nota final es: {notaFinal}\t-\tLiteral: F\nReprobado por no cumplir la nota mínima del examen final!!!");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Su nota final es: {notaFinal}\t-\tLiteral: F");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;

                case 12:
                    Console.WriteLine("Realizar programa que desglose billetes y monedas basado en un número introducido por teclado.");
                    Console.Write("\nDigite un número: ");
                    int dinero = Convert.ToInt32(Console.ReadLine());
                    double dosciento = dinero / 200;
                    double cien = dinero / 100;
                    double cincuenta = dinero / 50;
                    double veinticinco = dinero / 25;
                    double diez = dinero / 10;
                    double cinco = dinero / 5;
                    if (dosciento >= 1)
                    {
                        Console.WriteLine($"\nBilletes de 200: {Math.Round(dosciento, 0)}");
                    }
                    if (cien >= 1)
                    {
                        Console.WriteLine($"Billetes de 100: {Math.Round(cien, 0)}");
                    }
                    if (cincuenta >= 1)
                    {
                        Console.WriteLine($"Billetes de 50: {Math.Round(cincuenta, 0)}");
                    }
                    if (veinticinco >= 1)
                    {
                        Console.WriteLine($"Monedas de 25: {Math.Round(veinticinco, 0)}");
                    }
                    if (diez >= 1)
                    {
                        Console.WriteLine($"Monedas de 10: {Math.Round(diez, 0)}");
                    }
                    if (cinco >= 1)
                    {
                        Console.WriteLine($"Monedas de 5: {Math.Round(cinco, 0)}");
                    }
                    break;

                case 13:
                    Console.WriteLine("Realizar programa que calcule el salario neto, basado en el salario bruto, realizando calculo de AFP y Seguro de Salud. El programa debe recibir cantidad de horas trabajadas\r\nlas horas extras a partir de las 44 horas se pagan a 30% adiccional.");
                    Console.Write("\nDigite su salario bruto anual: ");
                    double salarioBrutoAnual = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite horas trabajadas: ");
                    int horasTrabajadas = Convert.ToInt16(Console.ReadLine());
                    double salarioNetoAnual = (salarioBrutoAnual * 0.1) * 0.062;
                    double salarioNetoMensual = (salarioBrutoAnual - salarioNetoAnual) / 12;
                    if (horasTrabajadas > 44)
                    {
                        double salarioNetoMensualAdicional = salarioNetoMensual + salarioNetoMensual * 0.3;
                        Console.WriteLine($"Su salario neto mensual es: {salarioNetoMensualAdicional}");
                    }
                    else
                    {
                        Console.WriteLine($"Su salario neto mensual es: {salarioNetoMensual}");
                    }
                    break;

                case 14:
                    Console.WriteLine("Realizar programa que resuelva ecuaciones lineales de primer grado.");
                    Console.Write("\n1- Ecuaciones lineales con formato: Ax = B\n" +
                        "2- Ecuaciones lineales con formato: Ax = Bx + C\n" +
                        "3- Ecuaciones lineales con formato: Ax + B = C\n" +
                        "4- Ecuaciones lineales con formato: Ax + B = Cx\n" +
                        "5- Ecuaciones lineales con formato: Ax + B = Cx + D\n\nElige una opción: ");
                    int ecuacion = Convert.ToInt16(Console.ReadLine());
                    switch (ecuacion)
                    {
                        case 1:
                            Console.Write("\nDigite A: ");
                            double ax1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite B: ");
                            double b1 = Convert.ToInt32(Console.ReadLine());
                            if(ax1 != 0)
                            {
                                Console.WriteLine($"\nX= {Math.Round(b1/ax1,2)}");
                            }
                            else
                            {
                                Console.WriteLine("Indefinido, el valor de A no puede ser 0!!!");
                            }
                            break;
                        case 2:
                            Console.Write("\nDigite A: ");
                            double ax2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite B: ");
                            double bx2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite C: ");
                            double c2 = Convert.ToInt32(Console.ReadLine());
                            double ax2_bx2 = ax2 + (-bx2);
                            if (ax2_bx2 != 0)
                            {
                                Console.WriteLine($"\nX= {Math.Round(c2 / ax2_bx2,2)}");
                            }
                            else
                            {
                                Console.WriteLine("Indefinido, la operación de A y B no puede dar 0!!!");
                            }
                            break;
                        case 3:
                            Console.Write("\nDigite A: ");
                            double ax3 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite B: ");
                            double b3 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite C: ");
                            double c3 = Convert.ToInt32(Console.ReadLine());
                            double b3_c3 = (-b3) + c3;
                            if (ax3 != 0)
                            {
                                Console.WriteLine($"\nX= {Math.Round(b3_c3 / ax3,2)}");
                            }
                            else
                            {
                                Console.WriteLine("Indefinido, el valor de A no puede ser 0!!!");
                            }
                            break;
                        case 4:
                            Console.Write("\nDigite A: ");
                            double ax4 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite B: ");
                            double b4 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite C: ");
                            double cx4 = Convert.ToInt32(Console.ReadLine());
                            double ax4_cx4 = ax4 + (-cx4);
                            double b4Negativo = -b4;
                            if (ax4_cx4 != 0)
                            {
                                Console.WriteLine($"\nX= {Math.Round(b4Negativo / ax4_cx4,2)}");
                            }
                            else
                            {
                                Console.WriteLine("Indefinido, la operación de A y C no puede dar 0!!!");
                            }
                            break;
                        case 5:
                            Console.Write("\nDigite A: ");
                            double ax5 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite B: ");
                            double b5 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite C: ");
                            double cx5 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite D: ");
                            double d5 = Convert.ToInt32(Console.ReadLine());
                            double ax5_cx5 = ax5 + (-cx5);
                            double b5_d5 = (-b5) + d5;
                            if (ax5_cx5 != 0)
                            {
                                Console.WriteLine($"\nX= {Math.Round(b5_d5 / ax5_cx5,2)}");
                            }
                            else
                            {
                                Console.WriteLine("Indefinido, la operación de A y C no puede dar 0!!!");
                            }
                            break;
                        default:
                            Console.WriteLine("Opción no válida!!!");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida!!!");
                    break;

            }
            Console.Read();
        }
    }
}
