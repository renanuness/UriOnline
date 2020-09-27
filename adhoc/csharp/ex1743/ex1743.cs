using System;

class URI
{
    static void Main(string[] args)
    {
        var conector1 = Console.ReadLine();
        var conector2 = Console.ReadLine();

        conector1 = conector1.Trim();
        conector2 = conector2.Trim();

        Console.Write("{0}\n", conector1);
        bool compativel = true;
        
        for(int i = 0; i < conector1.Length; i++)
        {
            if(conector1[i] == conector2[i] && !char.IsWhiteSpace(conector1[i]))
                compativel = false;
        }

        if(compativel)
            Console.Write("Y\n");
        else
            Console.Write("N\n");
    }
}