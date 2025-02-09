using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_1_Segundo_Parcial
{
    public class Asalariado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public string Tipo { get; set; }
        public double TasaMensual { get; set; }
        public double TasaAnual { get; set; }
        public Asalariado(int id, string nombre, int salario)
        {
            Id = id;
            Nombre = nombre;
            Salario = salario;
            TasaMensual = 0;
            TasaAnual = 0;
            if (salario <= 416220)
            {
                Tipo = Tasa.Exento.ToString();
            }
            else
            {
                if (salario >= 416220.01 && salario <= 624329)
                {
                    Tipo = Tasa.QuincePorciento.ToString();
                }
                else
                {
                    if (salario >= 624329.01 && salario <= 867123)
                    {
                        Tipo = Tasa.VeintePorCiento.ToString();
                    }
                    else
                    {
                        if (salario >= 867123.01)
                        {
                            Tipo = Tasa.VeintiCincoPorCiento.ToString();
                        }
                    }
                }
            }
        }
        public enum Tasa
        {
            Exento = 0,
            QuincePorciento = 1,
            VeintePorCiento = 2,
            VeintiCincoPorCiento = 3
        }
    }
}
