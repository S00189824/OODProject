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
            

            var query = from s in db.Songs
                        select s.SongName;

            lbxMusic.ItemsSource = query.ToString();
            Console.WriteLine(query.ToString());
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
    }
}
