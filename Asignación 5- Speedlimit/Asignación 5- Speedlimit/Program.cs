using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_5__Speedlimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DatosArreglo
            Random random = new Random();
            int[] ints = new int[10];
            Carro[] carros = new Carro[10];
            for (int i = 0; i < carros.Length; i++)
            {
                ints[i] = random.Next(100, 200);
            }
            carros[0] = new Carro("A123", ints[0]);
            carros[1] = new Carro("B456", ints[1]);
            carros[2] = new Carro("C789", ints[2]);
            carros[3] = new Carro("D012", ints[3]);
            carros[4] = new Carro("E345", ints[4]);
            carros[5] = new Carro("F678", ints[5]);
            carros[6] = new Carro("G901", ints[6]);
            carros[7] = new Carro("H234", ints[7]);
            carros[8] = new Carro("I567", ints[8]);
            carros[9] = new Carro("J890", ints[9]);
            #endregion
            #region CapturarN
            Console.Write("Digite un número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            #endregion
            #region OrdenarArreglo
            Carro temp;
            for (int i = 0; i < carros.Length; i++)
            {
                for (int j = 0; j < carros.Length; j++)
                {
                    if (carros[j].Velocidad < carros[i].Velocidad)
                    {
                        temp = carros[j];
                        carros[j] = carros[i];
                        carros[i] = temp;
                    }
                }
            }
            #endregion
            #region ImprimirArreglo
            int a = 0;
            Console.WriteLine("Arreglo ordenado descendentemente:\n");
            foreach (var c in carros)
            {
                Console.WriteLine($"Carro con matrícula: {carros[a].Matricula}, velocidad máxima: {carros[a].Velocidad}km/h");
                a++;
            }
            #endregion
            #region MayoresMenores
            Console.WriteLine();
            Console.WriteLine("\nMáximos\n");
            try
            {
                for (int i = n; i > 0; i--)
                {
                    Console.WriteLine($"Carro matricula: {carros[n - i].Matricula}, Velocidad máxima: {carros[n - i].Velocidad}km/h");
                }
                Console.WriteLine("\nMínimos\n");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Carro matricula: {carros[carros.Length - (i + 1)].Matricula}, Velocidad mínima: {carros[carros.Length - (i + 1)].Velocidad}km/h");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nOcurrio un error inesperado, posible solución: Elegir un número menor!");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
