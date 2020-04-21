using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OODProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer player = new MediaPlayer();
        List<Artists> Artists = new List<Artists>();
        DirectoryInfo desktopfolder = new DirectoryInfo(@"C:\Users\david\OneDrive\Desktop" + "\\Music");
        SongData db = new SongData();
        


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

            //var query = from a in db.Artists
            //            select a;
            ////var result = query.ToList();
            //lbxMusic.ItemsSource = query.ToList();
            
        }


        


        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            string directoryname = @"C:\Users\David\Documents\GitHub\OODProject\OODProject\OODProject\Artists\Witcher\";
            string songname = "GWENT The Witcher Card Game OST - Monstrous Might";
            string filetype = ".mp3";

            Uri song = new Uri(directoryname + songname + filetype, UriKind.Relative);

            player.Open(song);
            player.Play();
        }

        private void LbxMusic_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void LbxMusic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string directoryname_Nier = @"C:\Users\David\Documents\GitHub\OODProject\OODProject\OODProject\Artists\Witcher\";
            string directoryname_Witcher = @"C:\Users\David\Documents\GitHub\OODProject\OODProject\OODProject\Artists\Nier\";

            string[] Nier_songs = { "Dark Colossus - Kaiju", "Emil - Despair", "Significance - Nothing - J'Nique Nicole", "The Sound of the End", "War & War" };

            var query = from a in db.Artists
                        select a;
            //var result = query.ToList();
            lbxMusic.ItemsSource = query.ToList();
        }

        private void BtnCycleLeft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCycleRight_Click(object sender, RoutedEventArgs e)
        {

        }

        void SetArtist()
        {

        }
    }
}
