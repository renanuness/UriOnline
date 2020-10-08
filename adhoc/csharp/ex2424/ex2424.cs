using System;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Console.ReadLine();

        var x = Int32.Parse(entradas.Split(' ')[0]);
        var y = Int32.Parse(entradas.Split(' ')[1]);
    
        bool bolaFora = false;
        if(x < 0 || x > 432)
            bolaFora = true;
        if(y < 0 || y > 468)
            bolaFora = true;

        var saida = bolaFora ? "fora" : "dentro";

        Console.Write("{0}\n", saida);
    }
}