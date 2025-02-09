using System.Windows;

namespace Tarea_4___Udemy
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            LoginDialogBox login = new LoginDialogBox();
            bool? result = login.ShowDialog();
            if (result == true)
            {
                MessageBox.Show("Excelente, adelante!!!");
                this.WindowState = WindowState.Normal;
            }
            else
            {
                MessageBox.Show("Lo lamento, adios!!!");
                this.Close();
            }
        }
    }
}
