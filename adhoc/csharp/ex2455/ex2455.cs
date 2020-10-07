using System;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Console.ReadLine();

        var p1 = Int32.Parse(entradas.Split(' ')[0]);
        var c1 = Int32.Parse(entradas.Split(' ')[1]);
        var p2 = Int32.Parse(entradas.Split(' ')[2]);
        var c2 = Int32.Parse(entradas.Split(' ')[3]);
    
        var f1 = p1*c1;
        var f2 = p2*c2; 
        
        var saida = 0;
        if(f1 > f2)
            saida = -1;
        if(f2 > f1)
            saida = 1;

        Console.Write("{0}\n", saida);
    }
}