using KonyvtarApi.Models;
using KonyvtarKliens.DTOs;
using KonyvtarKliens.Services;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KonyvtarKliens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static HttpClient sharedClient = new() 
        {
            BaseAddress = new("http://localhost:5000") 
        };
        private static List<KonyvtarakDTO> konyvtarak = new();
        public MainWindow()
        {
            InitializeComponent();
            FeltoltKonyvtar();
        }

        private void btnUj_Click(object sender, RoutedEventArgs e)
        {
            //Új könyvtár objektum létrehozása
            Konyvtarak ujKonyvtar = new()
            {
                KonyvtarNev = tbxKonyvtarNev.Text,
                Irsz = int.Parse(tbxIrsz.Text),
                Cim = tbxCim.Text
            };
            //konyvtarService osztály PostNew metódusának meghívása
            string valasz = KonyvtarService.PostNew(sharedClient, ujKonyvtar).Result;
            MessageBox.Show(valasz);
            //adatok újratöltése
            FeltoltKonyvtar();
        }

        private void btnModosit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void FeltoltKonyvtar()
        {
            konyvtarak = await KonyvtarService.GetAll(sharedClient);
            //Task.Delay(1000).Wait();
            dgrKonyvtarak.ItemsSource = konyvtarak;
        }
    }
}