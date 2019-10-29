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
    /// Lógica de interacción para WindowCreateUser.xaml
    /// </summary>
    public partial class WindowCreateUser : Window
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

        public WindowCreateUser()
        {
            InitializeComponent();
            loadForms();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((string.IsNullOrWhiteSpace(CreateUser_textbox.Text))||(string.IsNullOrWhiteSpace(CreatePassword_textbox.Text))|| (string.IsNullOrWhiteSpace(code_textbox.Text)))
            {
                MessageBox.Show("Don't leave empty boxes");
            }
            else
            {
                Usuarios nuevoUsuario = new Usuarios(CreateUser_textbox.Text, CreatePassword_textbox.Text);

                try
                {
                    StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Users.txt", append: true);
                    sw.WriteLine(nuevoUsuario.ToString());
                    sw.Close();
                    MessageBox.Show("The user has been created successfully " + nuevoUsuario.ToString());


                    //agregar a un nuevo archivo txt que se cargará al check status

                    String msg1 = "Congrats! you have been accepted. This is your username and password: ";
                    String user = "Username: " + CreateUser_textbox.Text;
                    String pass = "Password: " + CreatePassword_textbox.Text;
                    foreach (string l in formularios) //l es cada formulario
                    {
                        if (code_textbox.Text.Equals(l.Split(';')[0]))
                        {
                            string formNum = l.Split(';')[0]; //este es el numero del formulario
                            StreamWriter sd = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Check Status.txt", append: true);
                            sd.WriteLine(formNum.ToString() + ";" + msg1 + ";" + user + ";" + pass);
                            sd.Close();
                        }
                    }

                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("An unexpected error ocurred");
                }
            }
           
            
        }
    }
}
