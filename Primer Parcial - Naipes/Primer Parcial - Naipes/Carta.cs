using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial___Naipes
{
    public class Carta
    {
        public string TipoCarta { get; set; }
        public string NumeroCarta { get; set; }
        public Carta(string tipoCarta, string numeroCarta)
        {
            TipoCarta = tipoCarta;
            NumeroCarta = numeroCarta;
        }
        public void SuCartaEs()
        {
            Console.WriteLine($"{NumeroCarta} de {TipoCarta}");
        }
        public void Barajar()
        {
            Console.WriteLine("Barajando cartas!!!");
        }
        public void Repartir()
        {
            Console.WriteLine("Repartiendo cartas!!!");
        }
    }
}
