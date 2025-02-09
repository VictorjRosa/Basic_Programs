using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoremadePitagora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Teorema de Pitagoras!!!\n\nOpciones a encontrar:\n\n1- Hipotenusa\n2- Cateto Opuesto\n3- Cateto Adyacente\n\nElija una opción: ");
            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Digite el cateto opuesto: ");
                    int cttOpuesto1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Digite el cateto adyacente: ");
                    int cttAdyacente1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"La hipotenusa es igual a: {Math.Round(Math.Sqrt(Math.Pow(cttOpuesto1,2)+Math.Pow(cttAdyacente1,2)),2)}");
                    break;
                case 2:
                    Console.Write("Digite la hipotenusa: ");
                    int hipotenusa2 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Digite el cateto opuesto: ");
                    int cttOpuesto2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"El cateto opuesto es igual a: {Math.Round(Math.Sqrt(Math.Pow(hipotenusa2, 2) - Math.Pow(cttOpuesto2, 2)),2)}");
                    break;
                case 3:
                    Console.Write("Digite la hipotenusa: ");
                    int hipotenusa3 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Digite el cateto adyacente: ");
                    int cttAdyacente3 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"El cateto adyacente es igual a: {Math.Round(Math.Sqrt(Math.Pow(hipotenusa3, 2) - Math.Pow(cttAdyacente3, 2)),2)}");
                    break;
                default:
                    Console.Write("Opción no válida!!!");
                    break;
            }

            Console.Read();
        }
    }
}
