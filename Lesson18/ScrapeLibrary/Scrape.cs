using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }
        public string ScrapeWebpage(String url, string filepath)
        {
            string reply = GetWebpage(url);

            System.IO.File.WriteAllText(@"C:\Users\abelm\Desktop\c-sharp-basics\WriteText.txt", reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
