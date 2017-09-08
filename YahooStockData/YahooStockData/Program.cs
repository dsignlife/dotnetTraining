using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace YahooStockData
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string csvData;

            using (WebClient web = new WebClient())
            {
                csvData = web.DownloadString("http://finance.yahoo.com/d/quotes.csv?s=AAPL&f=snbaopl1");
            }

            List<Price> prices = YahooFinance.Parse(csvData);

            foreach (Price price in prices)
            {
                WriteLine
                    ($"Name: {price.Name} \n" +
                     $"Symbol: {price.Symbol}\n" +
                     $"Bid: {price.Bid} \n" +
                     $"Offer: {price.Ask} \n" +
                     $"Last: {price.Last} \n" +
                     $"Open: {price.Open} \n" +
                     $"PreviousClose: {price.PreviousClose} ");
            }

            Read();

        }
    }

    public static class YahooFinance
    {
        public static List<Price> Parse(string csvData)
        {
            List<Price> prices = new List<Price>();
            var culture = CultureInfo.InvariantCulture;
            string[] rows = csvData.Replace("\"", "").Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row)) continue;

                string[] cols = row.Split(',');

                Price p = new Price();
                p.Symbol = cols[0];
                p.Name = cols[1];
                p.Bid = decimal.Parse(cols[2], culture);
                p.Ask = Convert.ToDecimal(cols[3], culture);
                p.Open = Convert.ToDecimal(cols[4], culture);
                p.PreviousClose = Convert.ToDecimal(cols[5], culture);
                p.Last = Convert.ToDecimal(cols[6], culture);

                prices.Add(p);
            }

            return prices;
        }
    }

    public class Price
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public decimal Open { get; set; }
        public decimal PreviousClose { get; set; }
        public decimal Last { get; set; }
    }
}
