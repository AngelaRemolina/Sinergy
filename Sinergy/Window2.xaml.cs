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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<string> cultureList = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;
        public Window2()
        {
            InitializeComponent();
            foreach (CultureInfo culture in cultures)
            {
                region = new RegionInfo(culture.LCID);
                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                    Country_Combo.Items.Add(region.EnglishName);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(FirstName_TextBox.Text) || string.IsNullOrWhiteSpace(Email_TextBox.Text)
                || string.IsNullOrWhiteSpace(Adress_TextBox.Text) || string.IsNullOrWhiteSpace(KeyInfo_TextBox.Text)
                || string.IsNullOrEmpty(Country_Combo.Text) || string.IsNullOrEmpty(Rights_Combo.Text)
                || string.IsNullOrEmpty(Transfer_Combo.Text) || string.IsNullOrEmpty(distributor_Combo.Text)
                || string.IsNullOrEmpty(Genre_Combo.Text) || string.IsNullOrEmpty(appliedbefore_Combo.Text))
            {
                MessageBox.Show("All the options must be filled");
            }

            if (!(bool)terms_CheckBox.IsChecked)
            {
                MessageBox.Show("You must agree with the terms and data policy ");
            }

            if (!string.IsNullOrWhiteSpace(FirstName_TextBox.Text) && !string.IsNullOrWhiteSpace(Email_TextBox.Text)
                && !string.IsNullOrWhiteSpace(Adress_TextBox.Text) && !string.IsNullOrWhiteSpace(KeyInfo_TextBox.Text) &&
                (bool)terms_CheckBox.IsChecked && !string.IsNullOrEmpty(Country_Combo.Text) && !string.IsNullOrEmpty(Rights_Combo.Text)
                && !string.IsNullOrEmpty(Transfer_Combo.Text) && !string.IsNullOrEmpty(distributor_Combo.Text)
                && !string.IsNullOrEmpty(Genre_Combo.Text) && !string.IsNullOrEmpty(appliedbefore_Combo.Text))
            {


                Random random = new Random();
                int codigo = random.Next(9999);

                MessageBox.Show("Your application is compleated. Application code: " + codigo.ToString() + "\nPlease check the status of your application in a couple of days.");
                //guardar el registro en archivo
                Formulario newForm = new Formulario(FirstName_TextBox.Text, Email_TextBox.Text,
                    Adress_TextBox.Text, KeyInfo_TextBox.Text, Country_Combo.Text, Rights_Combo.Text,
                    Transfer_Combo.Text, distributor_Combo.Text, Genre_Combo.Text, appliedbefore_Combo.Text);
                try
                {
                    StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\formularios.txt", append: true);
                    sw.WriteLine(codigo +";"+ newForm.ToString());
                    sw.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error con el archivo y no se pudo registrar");
                }
                finally
                {
                    MainWindow main = new MainWindow();
                    this.Close();
                    main.ShowDialog();
                    this.Show();
                    formFormulario.Close();
                }
            }
        }

        private void Button_backtomain2_Click(object sender, RoutedEventArgs e)
        {
            formFormulario.Close();
        }

        private void Button_exit3_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        
       



    }
}
