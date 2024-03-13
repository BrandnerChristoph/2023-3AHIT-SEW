using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

namespace AsyncAwaitExample
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

        private void BtnClick_RunSync(object sender, RoutedEventArgs e)
        {
            // Code wird abgearbeitet
            result_txtBlock.Text = string.Empty;

            Stopwatch sw = new Stopwatch();
            result_txtBlock.Text += "Image download startet (" + repeat_txtB.Text + " times) ...\n";
            sw.Start();

            int repeat = int.Parse(repeat_txtB.Text);
            for (int i = 0; i < repeat; i++)
            {
                DownloadImage();
            }

            sw.Stop();
            WriteStopwatch(sw.ElapsedMilliseconds);
        }

        private async void BtnClick_RunAsync(object sender, RoutedEventArgs e)
        {
            // Code wird abgearbeitet
            result_txtBlock.Text = string.Empty;

            Stopwatch sw = new Stopwatch();
            result_txtBlock.Text += "Image download startet (" + repeat_txtB.Text + " times) ...\n";
            sw.Start();

            int repeat = int.Parse(repeat_txtB.Text);
            for (int i = 0; i < repeat; i++)
            {
                await Task.Run(() => DownloadImage());
            }

            sw.Stop();
            WriteStopwatch(sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Zusammenfassung des Downloads
        /// </summary>
        /// <param name="time"></param>
        private void WriteStopwatch(long time)
        {
            result_txtBlock.Text += "\nDownload abgeschlossen. Dauer: " + time + "ms";
        }

        /// <summary>
        /// Bild herunterladen
        /// </summary>
        private void DownloadImage()
        {
            try
            {
                string img = "https://www.htlwy.at/wp2017/wp-content/themes/htl2017/assets/Logo_HTLWaidhofen_std_fbg_rgb_web.png";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(img);
                HttpWebResponse response = ((HttpWebResponse)request.GetResponse());
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                response.Close();
                readStream.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Image download failed", ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
