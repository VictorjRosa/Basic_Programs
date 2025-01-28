using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_2___Animales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cantidad de perros a introducir: ");
            Perro[] perro = new Perro[Convert.ToInt16(Console.ReadLine())];
            
            for (int i = 0; i < perro.Length; i++)
            {
                Console.WriteLine("Digite raza del perro " + (i + 1) + ": ");
                string raza = Console.ReadLine();
                perro[i] = new Perro(raza, 1);
            }
            Console.Clear();

            foreach (var Perro in perro)
            {
                Console.WriteLine($"Raza: {Perro.Raza}, cantidad: {Perro.Cant}");
            }

            Console.Read();
        }
    }
}
