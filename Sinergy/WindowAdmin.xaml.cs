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
using System.Windows.Shapes;

namespace Entorno_visual
{
    /// <summary>
    /// Lógica de interacción para WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowCreateUser PantallaCreateUser = new WindowCreateUser();
            this.Hide();
            PantallaCreateUser.ShowDialog();
            this.Show();

        }

        private void ButtonExit5_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_SignOut_Click(object sender, RoutedEventArgs e)
        {
            WindowLogin login = new WindowLogin();
            this.Close();
            login.ShowDialog();
            this.Show();
            formAdmin.Close();
        }

        private void Button_CheckForms_Click(object sender, RoutedEventArgs e)
        {
            WindowCheckForms check = new WindowCheckForms();
            this.Hide();
            check.ShowDialog();
            this.Show();
        }
    }
}
