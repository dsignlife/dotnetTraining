using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HtmlDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"\Page";
            string htmlExtension = ".html";
            Console.WriteLine("loading...");
            string desktopPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string site = client.DownloadString("https://www.google.com/");
            File.WriteAllText(desktopPath + fileName + htmlExtension, site);
            Console.WriteLine(site);
            Console.WriteLine("\r\ndownloading finished!");
            Console.WriteLine(desktopPath + fileName + htmlExtension);
        }
    }
}
