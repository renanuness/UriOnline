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
        private string URL = "https://www.urionlinejudge.com.br/judge/pt/problems/index/1?page=PAGENUMBER";

        public async Task<List<string>> StartCrawlerAsync()
        {
            List<string> exerciciosId = new List<string>();

            for (int i = 1; i <= 6; i++)
            {
                var url = URL.Replace("PAGENUMBER", i.ToString());
                var html = GetPage(url).Result;

                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                SelectTable(htmlDocument);

                var divs = htmlDocument.DocumentNode.Descendants("a")
                    .Where(node => node.ParentNode.Name.Equals("td") && node.ParentNode.GetAttributeValue("class", "").Equals("id ")).ToList();

                foreach (var element in divs)
                {
                    exerciciosId.Add(element.InnerHtml);
                }
            }
            return exerciciosId;
        }

        private void SelectTable(HtmlDocument htmlDocument)
        {
            var table = htmlDocument.DocumentNode.SelectNodes("//table//tbody//tr");
            
            foreach(var row in table)
            {
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(row.InnerHtml);
                var tds = document.DocumentNode.SelectNodes("//td");
                var last = tds.Last();
                var nivel = last.InnerText;
            }
        
        }

        private async Task<string> GetPage(string url)
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }
    }
}
