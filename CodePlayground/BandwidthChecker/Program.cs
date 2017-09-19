using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BandwidthChecker
{
    class Program
    {
        private const double timerUpdate = 1000;
        static int bytesSentSpeed = 0;
        static int bytesReceivedSpeed = 0;

        static void Main(string[] args)
        {

            int choice = 0;

            while (choice == 0)
            {


                if (choice == 0)
                {
                    var timer = new System.Threading.Timer(e => BandwidthChecker(), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
                    
                    choice = Convert.ToInt32(ReadLine());
                    
                }


                else
                {
                    Environment.Exit(0);
                }

            }

        }

        public static void BandwidthChecker()
        {

            IPv4InterfaceStatistics interfaceStats = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics();
            bytesSentSpeed = (int)(interfaceStats.BytesSent - bytesSentSpeed) / 1024;
            bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - bytesReceivedSpeed) / 1024;

            WriteLine($"Download: {bytesReceivedSpeed}\nUpload: {bytesSentSpeed}");
            SetCursorPosition(0, CursorTop -2);
            Read();


        }


    }
}
