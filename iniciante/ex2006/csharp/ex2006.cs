using System;

class URI
{
    static void Main(string[] args)
    {
        int cha = Int32.Parse(Console.ReadLine());
        int competidores = 5;
        int acertos = 0;
        int[] palpites = new int[competidores];

        string palpitesStr = Console.ReadLine();

        palpites[0] = Int32.Parse(palpitesStr.Split(' ')[0]);
        palpites[1] = Int32.Parse(palpitesStr.Split(' ')[1]);
        palpites[2] = Int32.Parse(palpitesStr.Split(' ')[2]);
        palpites[3] = Int32.Parse(palpitesStr.Split(' ')[3]);
        palpites[4] = Int32.Parse(palpitesStr.Split(' ')[4]);

        while(competidores-- > 0)
        {
            if(palpites[competidores] == cha) acertos++;
        }

        Console.Write("{0}\n", acertos);
    }
}