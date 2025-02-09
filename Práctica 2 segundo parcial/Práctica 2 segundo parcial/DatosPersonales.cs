using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2_segundo_parcial
{
    public class DatosPersonales
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public bool Validacion { get; set; }
        public DatosPersonales(int id, string nombre, string cedula, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            FechaNacimiento = fechaNacimiento;
            Edad = 0;
            Validacion = true;
        }
    }
}
