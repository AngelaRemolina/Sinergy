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
using System.Globalization;
using System.IO;

namespace Entorno_visual
{
    /// <summary>
    /// Lógica de interacción para WindowUpload.xaml
    /// </summary>
    public partial class WindowUpload : Window
    {
        List<string> cultureList = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;
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

        private void submit_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your release will be done when youe requested it");
        }

        private void All_checkBox_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)all_checkBox.IsChecked)
            {
                cb1.IsChecked = true;
                cb2.IsChecked = true;
                cb3.IsChecked = true;
                cb4.IsChecked = true;
                cb5.IsChecked = true;
                cb6.IsChecked = true;
                cb7.IsChecked = true;
            }
            if (!(bool)all_checkBox.IsChecked)
            {
                cb1.IsChecked = false;
                cb2.IsChecked = false;
                cb3.IsChecked = false;
                cb4.IsChecked = false;
                cb5.IsChecked = false;
                cb6.IsChecked = false;
                cb7.IsChecked = false;
            }
        }
    }
}
