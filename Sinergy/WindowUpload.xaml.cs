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
    /// Lógica de interacción para WindowUpload.xaml
    /// </summary>
    public partial class WindowUpload : Window
    {
        public WindowUpload()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            Window3_1 dashboard = new Window3_1();
            this.Close();
            dashboard.ShowDialog();
            this.Show();
            Upload.Close();
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown(); //Cerrar la app
        }
    }
}
