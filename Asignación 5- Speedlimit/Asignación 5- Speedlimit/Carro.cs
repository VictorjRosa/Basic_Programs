using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_5__Speedlimit
{
    public class Carro
    {
        public string Matricula { get; set; }
        public int Velocidad { get; set; }

        public Carro(string matricula, int velocidad)
        {
            Matricula = matricula;
            Velocidad = velocidad;
        }
    }
}
