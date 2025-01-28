using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_3___Ser_vivo
{
    public class SerVivo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Edad { get; set; }
        public SerVivo(string nombre, string tipo, int edad)
        {
            Nombre = nombre;
            Tipo = tipo;
            Edad = edad;
        }
        public virtual void BeberAgua()
        {
            Console.WriteLine("El ser vivo esta bebiendo agua!!!");
        }
        public void Crecer()
        {
            Console.WriteLine("El ser vivo esta creciendo!!!");
        }
    }
}
