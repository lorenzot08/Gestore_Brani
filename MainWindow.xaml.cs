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

namespace Gestore_Brani_CD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Brano b;

        private void bnt_creaBrano_Click(object sender, RoutedEventArgs e)
        {
             b = new Brano(txt_Titolo.Text, txt_Autore.Text, txt_Durata.Text);
        }

        private void btn_StampaDati_Click(object sender, RoutedEventArgs e)
        {
            lbl_StampaDati.Content = b.ToString();
        }

        private void btn_ShortSong_Click(object sender, RoutedEventArgs e, int durata)
        {
            
            if()
            {

            }
            else
            {

            }
        }
    }
}