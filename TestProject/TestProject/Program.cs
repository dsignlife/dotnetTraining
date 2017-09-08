using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceClient;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            test();
        }

        static void test()
        {

            var yahooFinanceClient = new YahooFinance.YahooFinance();
            var apple = yahooFinanceClient.RetrieveStock("AAPL");

            Console.WriteLine($"Ask Price is {apple.PricingData.Ask}");
            Console.WriteLine($"Bid Price is {apple.PricingData.Bid}");
            Console.WriteLine($"Open Price is {apple.PricingData.Open}");
            Console.WriteLine($"Previous Close is {apple.PricingData.PreviousClose}");


            // yahooFinanceClient = new YahooFinance.YahooFinance();
            // apple = yahooFinanceClient.RetrieveStock("AAPL");

            Console.WriteLine($"Volume is {apple.VolumeData.CurrentVolume}");
            Console.WriteLine($"Ask Size is {apple.VolumeData.AskSize}");
            Console.WriteLine($"Bid Size is {apple.VolumeData.BidSize}");
            Console.WriteLine($"Last Trade Size is {apple.VolumeData.LastTradeSize}");
            Console.WriteLine($"Average Daily Volume is {apple.VolumeData.AverageDailyVolume}");

        }
    }
}
