using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_Parcial___Bebidas_Alcoholicas
{
    public class Bebidas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IndiceTipo { get; set; }
        public string Tipo { get; set; }
        public int MiliLitros { get; set; }
        public double Precio { get; set; }
        public Bebidas(int id, string nombre, int indiceTipo, int miliLitros, double precio)
        {
            Id = id;
            Nombre = nombre;
            IndiceTipo = indiceTipo;
            MiliLitros = miliLitros;
            Precio = precio;
            if (indiceTipo == 1)
            {
                Tipo = TipoBebida.Whisky.ToString();
            }
            else
            {
                if (indiceTipo == 2)
                {
                    Tipo = TipoBebida.Ron.ToString();
                }
                else
                {
                    if (indiceTipo == 3)
                    {
                        Tipo = TipoBebida.Vino.ToString();
                    }
                    else
                    {
                        if (indiceTipo == 4)
                        {
                            Tipo = TipoBebida.Ginebra.ToString();
                        }
                        else
                        {
                            if (indiceTipo == 5)
                            {
                                Tipo = TipoBebida.Cognac.ToString();
                            }
                        }
                    }
                }
            }
        }
        public enum TipoBebida
        {
            Whisky = 1,
            Ron = 2,
            Vino = 3,
            Ginebra = 4,
            Cognac = 5
        }
    }
}
