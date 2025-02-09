using System.Windows;

namespace Tarea_4___Udemy
{
    /// <summary>
    /// Interaction logic for LoginDialogBox.xaml
    /// </summary>
    public partial class LoginDialogBox : Window
    {
        public LoginDialogBox()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
