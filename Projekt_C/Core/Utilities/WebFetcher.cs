using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_C.Core.Domain;
using System.Net.Http;

namespace Projekt_C.Core.Utilities
{
    static public class WebFetcher
    {
        private static HttpClient client = new HttpClient();
        

        public static Rss FetchRss(string url)
        {
            string content = Convert.ToString(FetchRssContent(url));

            var rss = new Rss
            {
                Url = url,
                Content = content
            };

            return rss;
        }

        public static async Task<String> FetchRssContent(string url)
        {
            return await client.GetStringAsync(url);
            
        }
    }
}
