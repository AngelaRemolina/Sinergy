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
using System.IO;

namespace Entorno_visual
{
    /// <summary>
    /// Lógica de interacción para WindowStatus.xaml
    /// </summary>
    public partial class WindowStatus : Window
    {
        List<String> formularios = new List<String>();
        private void loadForms()
        {
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\formularios.txt", Encoding.UTF8);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                formularios.Add(line);
            }
        }
        
        public WindowStatus()
        {
            InitializeComponent();
            loadForms();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<String> status = new List<String>();
            StreamReader statusReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Check Status.txt", Encoding.UTF8);
            string x;
            while ((x = statusReader.ReadLine()) != null)
            {
                status.Add(x); //agregar el txt a la lista de estados
            }


            int cont = 0;
            foreach (string stat in status)
            {
                if (StatusCode_TextBox.Text.Equals(stat.Split(';')[0])) 
                {
                    MessageBox.Show(stat.Split(';')[1]+ "\n"+ stat.Split(';')[2] + "\n"+ stat.Split(';')[3]);
                }
                else
                {
                    cont++;
                }
            }

            if (status.Count() == cont)
            {
                MessageBox.Show("We haven't checked your application yet.\nPlease check again in a couple of days");
            }
        }

        private void Button_Exit2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_backtomain_Click(object sender, RoutedEventArgs e)
        {
            formStatus.Close();
        }
    }
}
