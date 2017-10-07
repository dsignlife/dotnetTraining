using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLparsing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<Sololearner id = '1857356'><Name>Test</Name><Level>16</Level></Sololearner>");
                XmlNode node = doc.DocumentElement.SelectSingleNode("/Sololearner");
                string id = node.Attributes["id"]?.InnerText;
                Console.WriteLine("ID    : {0}", id);
                XmlNode nameNode = doc.DocumentElement.SelectSingleNode("/Sololearner/Name");
                Console.WriteLine("Name  : {0}", nameNode.InnerText);
                XmlNode levelNode = doc.DocumentElement.SelectSingleNode("/Sololearner/Level");
                Console.WriteLine("Level : {0}", levelNode.InnerText);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
