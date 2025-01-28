using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_3___Ser_vivo
{
    internal class Planta : SerVivo
    {
        public string TipoDePlanta { get; set; }
        public Planta(string nombre, string tipo, int edad) : base(nombre, tipo, edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public override void BeberAgua()
        {
            Console.WriteLine($"La planta {Nombre} esta absorviendo el agua!!!");
        }
        public void Fotosintesis()
        {
            Console.WriteLine($"La planta {Nombre} esta haciendo el proceso de fotosintesis!!!");
        }

    }
}
