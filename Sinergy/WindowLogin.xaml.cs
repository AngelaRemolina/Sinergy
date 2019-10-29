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
    /// Lógica de interacción para WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {

        

        //static Usuarios[] usuarios = new Usuarios[3] { new Usuarios("KTR", "1234"), new Usuarios("Mo", "4242"), new Usuarios("Admin", "*sinergy#") };




        public WindowLogin()
        {
            InitializeComponent();
            
        }

        private void Button_Login_validation_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(PasswordBox.Password) || string.IsNullOrWhiteSpace(UsernameBox.Text))
            {
                MessageBox.Show("Don't leave empty boxes");
            }
            if (UsernameBox.Text.Equals("Admin") && PasswordBox.Password.Equals("*sinergy#"))
            {
                WindowAdmin PantallaAdmin = new WindowAdmin();
                this.Close();
                PantallaAdmin.ShowDialog();
                this.Show();
            }
            else
            {
                List<String> users = new List<String>(); //lista con cada linea del txt

                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Users.txt", Encoding.UTF8);

                string striusuers;
                while ((striusuers = sr.ReadLine()) != null)
                {
                    users.Add(striusuers);
                }


                //bool flag = false;
                foreach (string i in users)
                {
                    string username = i.Split(';')[0];
                    string password = i.Split(';')[1];
                    if (UsernameBox.Text.Equals(username) && PasswordBox.Password.Equals(password))
                    {
                        Window3_1 Pantalla3_1 = new Window3_1();
                        this.Close();
                        Pantalla3_1.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        Label_if_incorrecto.Visibility = Visibility.Visible;
                    }
                    
                }
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
            this.Show();
            formLogin.Close();
        }


    }
}
