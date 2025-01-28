using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_3___Ser_vivo
{
    internal class Animal : SerVivo
    {
        public string TipoDeAnimal { get; set; }
        public Animal(string nombre, string tipo, int edad) : base(nombre, tipo, edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public override void BeberAgua()
        {
            Console.WriteLine($"El {TipoDeAnimal} {Nombre} esta bebiendo agua!!!");
        }
        public void Hablar()
        {
            Console.WriteLine($"El {TipoDeAnimal} {Nombre} esta hablando en su idioma animal!!!");
        }
    }
}
