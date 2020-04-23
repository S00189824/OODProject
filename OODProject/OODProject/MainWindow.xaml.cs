using NAudio.Wave;
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
using System.Windows.Threading;

namespace OODProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer player = new MediaPlayer();
        DirectoryInfo desktopfolder = new DirectoryInfo(@"C:\Users\david\OneDrive\Desktop" + "\\Music");
        SongDataInfo db = new SongDataInfo();
        List<string> artistnames = new List<string>();
        int x = 0;
        string url = "../../Assets/Pic";
        

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

            var query = from a in db.Artists
                        select a.Artistname;

            artistnames = query.ToList();
            SetArtist();
            SetSongs();
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



        private void LbxMusic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string directoryname_Nier = @"C:\Users\David\Documents\GitHub\OODProject\OODProject\OODProject\Artists\Witcher\";
            string directoryname_Witcher = @"C:\Users\David\Documents\GitHub\OODProject\OODProject\OODProject\Artists\Nier\";

            string[] Nier_songs = { "Dark Colossus - Kaiju", "Emil - Despair", "Significance - Nothing - J'Nique Nicole", "The Sound of the End", "War & War" };

            var query = from a in db.Artists
                        select a;
            //var result = query.ToList();
            test.ItemsSource = query.ToList();
        }



        private void BtnCycleLeft_Click(object sender, RoutedEventArgs e)
        {
            if(x== 1)
            {
                x--;
            }
            else
            {
                x = 1;
            }
            SetArtist();
            SetSongs();
        }

        private void BtnCycleRight_Click(object sender, RoutedEventArgs e)
        {
            if(x == 0)
            {
                x++;
            }
            else
            {
                x = 0;
            }
            SetArtist();
            SetSongs();
        }

        void SetArtist()
        {
            TblkArtistName.Text = artistnames[x];
            artistImage.Fill = new ImageBrush(new BitmapImage(new Uri(url + (x + 1).ToString() + ".jpg",UriKind.Relative)));
        }

        void SetSongs()
        {
            var query = from s in db.Songs
                        where s.ID == x + 1
                        select s.SongName;

            

            test.ItemsSource = query.ToList();

            
        }

    }
}
