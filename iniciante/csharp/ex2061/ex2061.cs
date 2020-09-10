using System;

class URI
{
    static void Main(string[] args)
    {
        string valores = Console.ReadLine();

        int abasInicias = Int32.Parse(valores.Split(' ')[0]);
        int acoes = Int32.Parse(valores.Split(' ')[1]);

        int iteracoes = acoes;
        while(iteracoes-- > 0)
        {
            string acao = Console.ReadLine();

            if(acao.Equals("fechou")) abasInicias++;
            else if(acao.Equals("clicou")) abasInicias--;
        }

        Console.Write("{0}\n", abasInicias);

    }
}