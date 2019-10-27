using System;
using System.IO;
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
    /// Lógica de interacción para WindowCheckForms.xaml
    /// </summary>
    public partial class WindowCheckForms : Window
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

            foreach (string l in formularios)
            {
                ListBoxForms.Items.Add(l.Split(';')[0]);
            }
        }
        public WindowCheckForms()
        {
            InitializeComponent();
            loadForms();
        }

        private void ListBoxForms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (string l in formularios) //l es cada formulario
            {
                string formNum = l.Split(';')[0]; //este es el numero del formulario

                if (ListBoxForms.SelectedItem.Equals(formNum)) //si el numero coincide con la seleccion del listbox
                {
                    string name = l.Split(';')[1];
                    string email = l.Split(';')[2];
                    string adress = l.Split(';')[3];
                    string country = l.Split(';')[4];
                    string keyInfo = l.Split(';')[5];
                    string rights = l.Split(';')[6];
                    string transfer = l.Split(';')[7];
                    string distributor = l.Split(';')[8];
                    string genre = l.Split(';')[9];
                    string applied = l.Split(';')[10];

                    FirstName_TextBox.Text = name;
                    email_Textbox.Text = email;
                    adress_textbox.Text = adress;
                    country_Textbox.Text = country;
                    keyInfo_textbox.Text = keyInfo;
                    rights_textbox.Text = rights;
                    transfer_textbox.Text = transfer;
                    distributor_textbox.Text = distributor;
                    genre_textbox.Text = genre;
                    applied_textbox.Text = applied;
                }
            }

        }

        private void Button_Accepted_Click(object sender, RoutedEventArgs e)
        {
            
            //Crear usuario aprobado
            WindowCreateUser windowsCreateUser = new WindowCreateUser();
            windowsCreateUser.ShowDialog();
        }

        private void Button_NotAccepted_Click(object sender, RoutedEventArgs e)
        {
            //agregar a un nuevo archivo txt que se cargará al check status
            String msg2 = "Sorry you were not accepted";

            foreach (string l in formularios) //l es cada formulario
            {
                if(ListBoxForms.SelectedItem.Equals(l.Split(';')[0]))
                {
                    string formNum = l.Split(';')[0]; //este es el numero del formulario
                    StreamWriter sd = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Check Status.txt", append: true);
                    sd.WriteLine(formNum + ";" + msg2);
                    sd.Close();
                    continue;
                }
            }

        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            WindowAdmin admin = new WindowAdmin();
            this.Close();
            admin.ShowDialog();
            this.Show();
            checkforms.Close();
        }
    }
}