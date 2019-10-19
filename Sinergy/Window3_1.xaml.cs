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
    /// Lógica de interacción para Window3_1.xaml
    /// </summary>
    public partial class Window3_1 : Window
    {
        public Window3_1()
        {
            InitializeComponent();
        }

        private void Release_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowUpload PantallaUpload = new WindowUpload();
            this.Hide();
            PantallaUpload.ShowDialog();
            this.Show();
        }

        private void Sing_Out_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
            this.Show();
            Dashboard.Close();
        }

        private void Button_exit4_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
