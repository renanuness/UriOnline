using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        Crawler crawler = new Crawler();

        crawler.LerPagina();
        crawler.LerBody();
        crawler.ImprimirBody();
    }
}

public class Crawler
{
    public List<string> HtmlPage {get; private set;}
    public List<string> Body {get; private set;}
    public Crawler()
    {
        HtmlPage = new List<string>();
        Body = new List<string>();
    }

    public void LerPagina()
    {
        while(LerLinha())
        {

        }
    }

    private bool LerLinha()
    {
        var linha = Console.ReadLine();
        if(string.IsNullOrEmpty(linha))
            return false;

        HtmlPage.Add(linha);
        return true;
    }

    public void LerBody()
    {
        int comeco = HtmlPage.FindIndex( x => x.Contains("<body>"));
        int final = HtmlPage.FindIndex( x => x.Contains("</body>"));
        
        for(int i = comeco+1; i < final; i++)
        {
            Body.Add(HtmlPage[i]);
        }
    }

    public void ImprimirBody()
    {
        foreach(var linha in Body)
        {
            Console.Write("{0}\n", linha);
        }
    }
}