using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BCCCBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            DB.GetConnect();
            reader2();
            
        }

        public static void reader2()
        {
            var testList = new List<string>();
            var culture = CultureInfo.InvariantCulture;
            String URLString =
                "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.xchange%20where%20pair%20in%20(%22BTCUSD%22)&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            XmlTextReader reader = new XmlTextReader(URLString);

            while (reader.Read())
            {
                
                switch (reader.NodeType)
                {


                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        testList.Add(reader.Value);
                        break;


                    default:
                        break;

                }
            }

            Console.WriteLine("Object in the list"
                + "\n##################");

            var prop = new Prop();
            prop.Name = testList[0];
            prop.Rate = Convert.ToDecimal(testList[1], culture); 
            prop.Date = testList[2];
            prop.Time = testList[3];
            prop.Ask = Convert.ToDecimal(testList[4], culture);
            prop.Bid = Convert.ToDecimal(testList[5], culture);

            
            Console.WriteLine($"{prop.Name} \n" +
                              $"{prop.Rate} \n" +
                              $"{prop.Date} \n" +
                              $"{prop.Time} \n" +
                              $"{prop.Ask} \n" +
                              $"{prop.Bid}");
            
        }

    }


}
