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
        string SongURL = "../../Artists/";
        SongDataInfo db = new SongDataInfo();
        List<ArtistInfo> artists = new List<ArtistInfo>();
        int x = 0;
        string url = "../../Assets/Pic";
        ArtistInfo currentArtist;
        bool playing = false;
        bool paused = false;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

            var query = from a in db.Artists
                        select a;

            artists = query.ToList();
            SetArtist();
            SetSongs();
        }


        

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            if(playing && paused)
            {
                player.Play();
                paused = false;
            }
            else if(playing && !paused)
            {
                player.Pause();
                paused = true;
            }
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
            TblkArtistName.Text = artists[x].Artistname;
            artistImage.Fill = new ImageBrush(new BitmapImage(new Uri(url + (x + 1).ToString() + ".jpg",UriKind.Relative)));
            currentArtist = artists[x];
        }

        void SetSongs()
        {
            var query = from s in db.Songs
                        where s.ID == x + 1
                        select s.SongName;

            

            test.ItemsSource = query.ToList();

            
        }

        private void Test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var song = test.SelectedItem;

            //Console.WriteLine(song);
            if (song != null)
            {
                player.Stop();

                Uri songTOPlay = new Uri(SongURL + currentArtist.Artistname + "/" + song + ".mp3", UriKind.Relative);
                Console.WriteLine(songTOPlay);
                player.Open(songTOPlay);
                player.Play();
                playing = true;
            }
        }
    }
}
