using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen_Final___Llegaron_los_aparatos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        List<double> precios = new List<double>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            precios.Add(Convert.ToDouble(txtPrecioAparato.Text));
            lb_VerDatos.Items.Add($"ID: {precios.Count}\nNombre: {txtNombreAparato.Text}\nPrecio: ${txtPrecioAparato.Text}\nTipo: {cbbTipoAparato.Text}\n");
            MessageBox.Show("Datos Guardados");
            txtNombreAparato.Clear();
            txtPrecioAparato.Clear();
            lblPromedio.Content = precios.Average();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
