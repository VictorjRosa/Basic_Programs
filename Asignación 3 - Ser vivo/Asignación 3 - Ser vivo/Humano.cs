using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_3___Ser_vivo
{
    internal class Humano : SerVivo
    {
        public string NivelAcademico { get; set; }
        
        public Humano(string nombre, string tipo, int edad) : base(nombre, tipo, edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public override void BeberAgua()
        {
            Console.WriteLine($"El humano {Nombre} esta bebiendo agua!!!");
        }
        public void Estudiar()
        {
            Console.WriteLine($"El humano {Nombre} esta estudiando!!!");
        }
    }
}
