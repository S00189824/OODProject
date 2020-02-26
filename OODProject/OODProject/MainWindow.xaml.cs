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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OODProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Songs> AllSongs = new List<Songs>();


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Songs S1 = new Songs("sdfhjsf", 1, new DateTime(2019,1,10),new TimeSpan(0,2,22));
            Songs S2 = new Songs("aaa", 2, new DateTime(2015,09,10),new TimeSpan(0,2,55));
            Songs S3 = new Songs("aaa", 3, new DateTime(2014,09,10),new TimeSpan(0,3,55));
            Songs S4 = new Songs("aaa", 4, new DateTime(2020,09,10),new TimeSpan(0,4,55));
            Songs S5 = new Songs("aaa", 5, new DateTime(2019,09,10),new TimeSpan(0,1,55));
            Songs S6 = new Songs("aaa", 6, new DateTime(2016,09,10),new TimeSpan(0,4,05));
            Songs S7 = new Songs("aaa", 7, new DateTime(2017,09,10),new TimeSpan(0,3,34));
            Songs S8 = new Songs("aaa", 8, new DateTime(2015,09,10),new TimeSpan(0,3,59));

            AllSongs.Add(S1);
            AllSongs.Add(S2);

            AllSongs.Add(S3);
            AllSongs.Add(S4);
            AllSongs.Add(S5);
            AllSongs.Add(S6);
            AllSongs.Add(S7);
            AllSongs.Add(S8);

            lbxMusic.ItemsSource = AllSongs;
        }
    }
}
