﻿using System;
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
        FileInfo ArtistFile;
        DirectoryInfo desktopfolder = new DirectoryInfo(@"C:\Users\david\OneDrive\Desktop" + "\\Music");

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }


        


        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            if(lbxMusic.SelectedIndex != -1)
            {
                
            }
        }
    }
}
