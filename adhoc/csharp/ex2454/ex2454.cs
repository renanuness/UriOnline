using System;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Console.ReadLine();

        var c1 = Int32.Parse(entradas.Split(' ')[0]);
        var c2 = Int32.Parse(entradas.Split(' ')[1]);
    
        char saida = 'A';
        if(c1 == 0)
            saida = 'C';
        else
        {
            if(c2 == 0)
                saida = 'B';
        }

        Console.Write("{0}\n", saida);
    }
}