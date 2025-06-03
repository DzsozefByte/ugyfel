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

namespace ugyfel
{
    /// <summary>
    /// Interaction logic for Regisztracio.xaml
    /// </summary>
    public partial class Regisztracio : Window
    {
        public Regisztracio()
        {
            InitializeComponent();
        }

        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            string nev = felhasznalo.Text;
            string jel = jelszo.Password;
            string jel2 = jelszoujra.Password;
            string mail = email.Text;
            if(string.IsNullOrEmpty(nev) || string.IsNullOrEmpty(jel))
            {
                MessageBox.Show("Kérlek töltsd ki az összes mezőt!", "Hiányzó adat(ok)!",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            if (jel != jel2)
            {
                MessageBox.Show("A két jelszó nem egyezik!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (mail.Contains("@") && mail.Contains("."))
            {
                MessageBox.Show("Sikeres regisztráció!", "Siker!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kérlek adj meg egy érvényes email címet!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
