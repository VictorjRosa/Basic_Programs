using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cedula
{
    public partial class Cedula : Form
    {
        public DateTime fechaExpiracion;
        public DateTime fechaNacimiento;

        public List<string> cedulas = new List<string>();
        public List<string> multiplo = new List<string>();
        public int word = 0;
        public string digVerificador = "";
        public int producto = 0;
        public int suma = 0;
        public int entero = 0;
        public int longitud = 0;
        public List<bool> result = new List<bool>();
        public Cedula()
        {
            InitializeComponent();
            fechaExpiracion = DateTime.Now.AddYears(10);
            TxtFechaExpiracion.Text = new DateTime(fechaExpiracion.Year,
                fechaExpiracion.Month,
                fechaExpiracion.Day).ToString("dd MMMM yyyy",
                CultureInfo.CreateSpecificCulture("es-MX"));
//            Random random= new Random();
            for (int i = 0; i < 1000; i++)
            {
//                int tresDig = random.Next(100, 1000);
//                int sieteDig = random.Next(1000000, 10000000);
//                int unDig = random.Next(0, 10);
                cedulas.Add($"{402}-{1369763}-{0}");
                VerificarCedula();
                if (result[result.Count - 1])
                {
                    TxtCedula.Text = cedulas[cedulas.Count - 1];
                    break;
                }
            }
        }
        private void FechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            fechaNacimiento = new DateTime(TxtFechaNacimiento.Value.Year,
                TxtFechaNacimiento.Value.Month,
                TxtFechaNacimiento.Value.Day);

            TxtFechaNacimiento.Text = new DateTime(fechaNacimiento.Year,
                fechaNacimiento.Month,
                fechaNacimiento.Day).ToString("dd MMMM yyyy",
                CultureInfo.CreateSpecificCulture("es-MX"));
            TxtFechaNacimiento.Visible = true;
        }
        private void VerificarCedula()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    multiplo.Add("1");
                }
                else
                {
                    multiplo.Add("2");
                }
            }
            List<string> cedulaSinGuion = new List<string>();
            foreach (var item in cedulas)
            {
                cedulaSinGuion.Add("");
            }
            for (int i = 0; i < cedulas.Count; i++)
            {
                foreach (char c in cedulas[i])
                {
                    if (c >= '0' && c <= '9' && c != '-')
                    {
                        cedulaSinGuion[i] = ((string.Concat(cedulaSinGuion[i], c)));
                    }
                }
            }
            for (int i = 0; i < cedulas.Count; i++)
            {
                suma = 0;
                longitud = multiplo.Count;
                foreach (char c in cedulaSinGuion[i])
                {
                    if (cedulaSinGuion[i] != "" && word <= 9)
                    {
                        producto = Convert.ToInt16(c - 48) * Convert.ToInt16(multiplo[word]);
                        suma += (producto / 10) + (producto % 10);
                    }
                    word++;
                }
                entero = (suma / 10) * 10;
                if (entero < suma)
                {
                    entero += 10;
                }
                digVerificador = Convert.ToString(entero - suma);
                if (digVerificador == cedulas[i].Substring(12, 1))
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
                word = 0;
            }
        }
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Cedulas; Integrated Security=True;");
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Insert Into Datos(Cedula, Nombres, Apellidos, Ocupacion, Sangre, Sexo, Provincia, EstadoCivil, Fecha_Expiracion, Fecha_Nacimiento )" +
                "Values(@Cedula, @Nombres, @apellidos, @ocupacion, @sangre, @sexo, @provincia, @estadoCivil, @fechaExpiracion, @fechaNacimiento)";
            SqlCommand command = new SqlCommand(query, conn)
            {
                CommandType = CommandType.Text,
            };
            command.Parameters.AddWithValue("@Cedula", TxtCedula.Text);
            command.Parameters.AddWithValue("@Nombres", TxtNombre.Text);
            command.Parameters.AddWithValue("@apellidos", TxtApellido.Text);
            command.Parameters.AddWithValue("@ocupacion", TxtOcupacion.Text);
            command.Parameters.AddWithValue("@sangre", TxtTipoSangre.Text);
            command.Parameters.AddWithValue("@sexo", TxtSexo.Text);
            command.Parameters.AddWithValue("@provincia", TxtProvincia.Text);
            command.Parameters.AddWithValue("@estadoCivil", CbbEstadoCivil.Text);
            command.Parameters.AddWithValue("@fechaExpiracion", TxtFechaExpiracion.Text);
            command.Parameters.AddWithValue("@fechaNacimiento", TxtFechaNacimiento.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Cédula guardada!");
            foreach (Control item in ActiveForm.Controls)
            {
                if (item.GetType() == new TextBox().GetType())
                {
                    TextBox obj = (TextBox)item;
                    obj.Clear();
                }
            }
            conn.Close();
            VerCedulas verCedulas = new VerCedulas();
            verCedulas.Show();
        }
    }
}
