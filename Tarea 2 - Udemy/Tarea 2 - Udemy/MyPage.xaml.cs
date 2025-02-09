using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Tarea_2___Udemy
{
    /// <summary>
    /// Interaction logic for MyPage.xaml
    /// </summary>
    public partial class MyPage : Page
    {
        public MyPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lblTitle.Text = "Mi Título";
            lblContent.Text = "Mi contenido";
        }

        private void BtnBoton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as NavigationWindow).Source = new Uri("https://www.google.com");
        }
    }
}
