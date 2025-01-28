using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_2___Animales
{
    internal class Perro
    {
        public string Raza { get; set; }
        public int Cant { get; set; }

        public Perro(string raza, int cant)
        {
            Raza = raza;
            Cant = cant;
        }
    }
}
