using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_3___Ser_vivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad de cada ser vivo: ");
            int cantidadSerVivo = Convert.ToInt16(Console.ReadLine());
            Humano[] humanos = new Humano[cantidadSerVivo];
            Planta[] plantas = new Planta[cantidadSerVivo];
            Animal[] animals = new Animal[cantidadSerVivo];
            int cantidad = humanos.Length + plantas.Length + animals.Length;
            SerVivo[] seresVivos = new SerVivo[cantidad];
            for (int i = 0; i < humanos.Length; i++)
            {
                Console.Write("\nDigite el nombre del humano: ");
                string nombre = Console.ReadLine();
                Console.Write("Digite la edad del humano: ");
                int edad = Convert.ToInt16(Console.ReadLine());
                humanos[i] = new Humano(nombre, "Humano", edad);
            }
            for (int i = 0; i < plantas.Length; i++)
            {
                Console.Write("\nDigite el nombre de la planta: ");
                string nombre = Console.ReadLine();
                Console.Write("Digite la edad de la planta: ");
                int edad = Convert.ToInt16(Console.ReadLine());
                plantas[i] = new Planta(nombre, "Planta", edad);
            }
            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write("\nDigite el nombre del animal: ");
                string nombre = Console.ReadLine();
                Console.Write("Digite la edad del animal: ");
                int edad = Convert.ToInt16(Console.ReadLine());
                animals[i] = new Animal(nombre, "Animal", edad);
            }
            int mas1 = 0;
            for (int j = 0; j < humanos.Length; j++)
            {
                seresVivos[j] = new SerVivo(humanos[mas1].Nombre, humanos[mas1].Tipo, humanos[mas1].Edad);
                mas1++;
            }
            int mas2 = 0;
            for (int k = humanos.Length; k < humanos.Length * 2; k++)
            {
                seresVivos[k] = new SerVivo(plantas[mas2].Nombre, plantas[mas2].Tipo, plantas[mas2].Edad);
                mas2++;
            }
            int mas3 = 0;
            for (int l = humanos.Length * 2; l < humanos.Length * 3; l++)
            {
                seresVivos[l] = new SerVivo(animals[mas3].Nombre, animals[mas3].Tipo, animals[mas3].Edad);
                mas3++;
            }
            Console.Clear();
            double treintaPorCiento = Math.Round(cantidad * 0.3,0);
            SerVivo temp;
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (seresVivos[j].Edad < seresVivos[i].Edad)
                    {
                        temp = seresVivos[j];
                        seresVivos[j] = seresVivos[i];
                        seresVivos[i] = temp;
                    }
                }
            }
            int menos = 0;
            Console.WriteLine("Arreglo ordenado en forma descendente!\n");
            while (menos != Convert.ToInt32(treintaPorCiento))
            {
                Console.Write($"El ser vivo de tipo {seresVivos[menos].Tipo}, llamado {seresVivos[menos].Nombre}, de edad {seresVivos[menos].Edad} años\n");
                menos++;
            }
            Console.ReadKey();
        }
    }
}
