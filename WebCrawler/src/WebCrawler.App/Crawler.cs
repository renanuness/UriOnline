using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.App
{
    public class Crawler
    {
        private string URL = "https://www.urionlinejudge.com.br/judge/pt/problems/index/PAGENUMBER?sort=Problems.level&direction=asc";

        public async Task<List<string>> StartCrawlerAsync()
        {
            List<string> exerciciosId = new List<string>();

            for ( int i = 1; i <= 6; i++)
            {
                var url = URL.Replace("PAGENUMBER", i.ToString());
                var html = GetPage(url).Result;

                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                var divs = htmlDocument.DocumentNode.Descendants("a")
                    .Where(node => node.ParentNode.Name.Equals("td") && node.ParentNode.GetAttributeValue("class", "").Equals("id ")).ToList();
            
                foreach ( var element in divs )
                {
                    exerciciosId.Add(element.InnerHtml);
                }
            }
            return exerciciosId;
        }

        private async Task<string> GetPage(string url)
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }
    }
}
