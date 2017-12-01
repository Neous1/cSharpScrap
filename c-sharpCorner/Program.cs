using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace c_sharpCorner
{
    class Program
    {
        static void Main(string[] args)
        {
            var web = new HtmlWeb();
            var doc =
                web.Load("https://www.yellowpages.com/search?search_terms=software+&geo_location_terms=Putnam%2C+CT");
            var headerNames = doc.DocumentNode.SelectNodes("//a[@class='business-name']").ToList();

            foreach (var item in headerNames)
            {
                Console.WriteLine(item.InnerText+"\n");
            }
        }
    }
}
