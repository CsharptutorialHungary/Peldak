using System;
using System.ComponentModel;
using System.Net;

namespace pelda_http2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;

                Uri cim = new Uri("http://releases.ubuntu.com/18.04.2/ubuntu-18.04.2-desktop-amd64.iso");
                client.DownloadFileAsync(cim, "d:\\ubuntu1804.iso");
                Console.ReadKey();
            }
        }

        private static void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.Write("{0} / {1} bytes, {2}%...\r", e.BytesReceived, e.TotalBytesToReceive, e.ProgressPercentage);
        }

        private static void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Done");
        }
    }
}
