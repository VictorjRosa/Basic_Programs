using System;
using System.Windows;
using System.Windows.Input;

namespace Tarea_1___Udemy
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
        private void BtnAswer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            Random random = new Random();
            if (txtQuestion.Text == "")
            {
                MessageBox.Show("Pregunta algo antes.");
            }
            else
            {
                txtAnswer.Text = random.Next(0, 2) == 0 ? "No" : "Si";
            }
            this.Cursor = null;
        }
    }
}
