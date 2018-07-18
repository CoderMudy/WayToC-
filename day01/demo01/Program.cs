using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ivony.Html;
using Ivony.Html.Parser;
using System.Xml.XPath;

namespace demo01
{
    class Program
    {

        static void Main(string[] args)
        {
            var parser = new JumonyParser();

            var document = parser.LoadDocument("http://www.cnblogs.com/");
 
            var elements = document.Find("#post_list > .post_item");
            foreach (var e in elements)
            {
                Console.WriteLine("title: {0}", e.FindFirst("h3 > a").InnerText());
                Console.WriteLine("link: {0}", e.FindFirst("h3 > a").Attribute("href").Value());
                Console.WriteLine("votes: {0}", e.FindFirst(".diggnum").InnerText());
                Console.WriteLine("author: {0}", e.FindFirst(".post_item_foot a.lightblue").InnerText());
                Console.WriteLine(new string('-', 30));
                Console.ReadKey();
            }　 
        }
    }


}
