using Microsoft.Win32;
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
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OpenSourceBar
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

        private void Vol_Change(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mpBox.Volume = Volume.Value;
            Volume_label1.Content = Volume.Value;
        }

        private void Media_Load_File(object sender, RoutedEventArgs e)
        {
            OpenFileDialog Media_File = new OpenFileDialog();
            Media_File.Title = "Open Video";
            Media_File.Filter = "MP4 files|*.mp3";
            //Media_File.InitialDirectory = @"C:\";
            if (Media_File.ShowDialog() == true)
            {
                MessageBox.Show(Media_File.FileName.ToString());
                var Media_File1 = Media_File.FileName.ToString();
                MediaPlayer mp = new MediaPlayer();
                //mpBox.Open(new Uri(Media_File1));
                mpBox.Source = new Uri(Media_File1);
                mpBox.Play();
            }
        }
    }
}
