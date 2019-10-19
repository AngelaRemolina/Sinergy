using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Entorno_visual
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            WindowLogin Pantalla2_2 = new WindowLogin();
            this.Hide();
            Pantalla2_2.ShowDialog();
            this.Show();
        }

        private void Button_Login2(object sender, RoutedEventArgs e)
        {
            WindowLogin Pantalla2_2 = new WindowLogin();
            this.Hide();
            Pantalla2_2.ShowDialog();
            this.Show();
            
        }


        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown(); //Cerrar la app
            //form_pantalla1.Close();
        }

        private void Button_Apply_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 Pantalla2 = new Window2();
            this.Hide();
            Pantalla2.ShowDialog();
            this.Show();
        }

        private void Button_Application_status_Click(object sender, RoutedEventArgs e)
        {
            WindowStatus PantallaStatus = new WindowStatus();
            this.Hide();
            PantallaStatus.ShowDialog();
            this.Show();
        }
    }
}
