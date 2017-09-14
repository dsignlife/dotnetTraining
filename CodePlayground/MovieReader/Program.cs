using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

namespace MovieReader
{
    class Program
    {
        public static string TitleResolver(string title)//only gets the characters from the feed
        {
            if (title.IndexOf("Search for other movies") >= 0)
            {
                return "_BLANK_";
            }
            string newtitle = "";
            int charcount = 0;
            if (!(title[0] >= 65 && title[0] <= 122))
            {
                for (int i = 0; i < title.Length - 1; i++)
                {
                    if ((title[i] >= 65 && title[i] <= 122) || title[i] == ' ' || title[i] == ':' || (int)title[i] == 39)
                    {
                        newtitle += title[i];
                        charcount++;
                    }

                }
                if (newtitle[1] == ' ')
                {
                    return "_BLANK_";
                }
                newtitle = newtitle.Substring(1, newtitle.Length - 1);
                return newtitle;
            }
            return title;

        }
        public static void PrintTitle(string rssurl)//prints the titles from the feed
        {
            try
            {
                XmlReader rssreader = XmlReader.Create(rssurl);
                SyndicationFeed data = SyndicationFeed.Load(rssreader);
                rssreader.Close();
                foreach (SyndicationItem feed in data.Items)
                {
                    String MovieTitle = feed.Title.Text;
                    MovieTitle = TitleResolver(MovieTitle);
                    if (MovieTitle != "" && MovieTitle != "_BLANK_")
                    {
                        Console.WriteLine("* " + MovieTitle);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("There Have been an error reading the current feed.");
                Console.WriteLine("Please try again later");
            }
        }
        static void Main(string[] args)
        {
            //enter nothing as input (he asks from some weird reason...)
            string Rss_url_newmovies = "http://www.fandango.com/rss/newmovies.rss";
            string Rss_url_boxoffice = "http://www.fandango.com/rss/top10boxoffice.rss";
            Console.WriteLine("\tNew Movies:");
            Console.WriteLine("reading from feed...\n");
            PrintTitle(Rss_url_newmovies);
            Console.WriteLine("\n");
            Console.WriteLine("\tCurrent Blockbusters:");
            Console.WriteLine("reading from feed...\n");
            PrintTitle(Rss_url_boxoffice);
            Console.WriteLine("\n\n");
        }
    }
}
