using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows;
using MahApps.Metro.Controls;

namespace WpfDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        List<string> listaLinkow = new List<string>();
        private WebClient _client = new WebClient();
        private Queue<Uri> _downloadQueue = new Queue<Uri>();

        public MainWindow()
        {
            InitializeComponent();
            _client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            _client.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(client_DownloadFileCompleted);
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DownloadNext();
            BtnDownload.Content = "Pobierz";
            BtnDownload.IsEnabled = true;
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            PbDownload.Value = int.Parse(Math.Truncate(percentage).ToString());

            BtnDownload.Content = "Pobieranie...";
            BtnDownload.IsEnabled = false;
        }



        // pobieranie
        private void Download_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var link in listaLinkow)
                {
                    _downloadQueue.Enqueue(new Uri(link));
                }

                DownloadNext();
            }
            catch (Exception ex)
            {
                ListViewResult.Items.Add(ex.Message);
            }
        }

        private void DownloadNext()
        {
            if (_downloadQueue.Count <= 0)
            {
                return;
            }

            var link = _downloadQueue.Dequeue().ToString();
            ListViewResult.Items.Add(link);


            var lastSlashIndex = link.LastIndexOf("/", StringComparison.Ordinal);
            _client.DownloadFileAsync(new Uri(link), link.Substring(lastSlashIndex + 1, link.Length - lastSlashIndex - 1));
        }

        //wybieranie
        private void OpenFile_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                PathTextBox.Text = openFileDialog.FileName;
                using (var reader = new StreamReader(openFileDialog.FileName))
                {
                    listaLinkow.AddRange(reader.ReadToEnd().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

                }
            }


        }

    }
}
