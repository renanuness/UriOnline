using System;

class URI
{
    static void Main(string[] args)
    {
        var disponiveis = Console.ReadLine();
        var pedidos = Console.ReadLine();

        var dA = Int32.Parse(disponiveis.Split(' ')[0]);
        var dB = Int32.Parse(disponiveis.Split(' ')[1]);
        var dC = Int32.Parse(disponiveis.Split(' ')[2]);
    
        var pA = Int32.Parse(pedidos.Split(' ')[0]);
        var pB = Int32.Parse(pedidos.Split(' ')[1]);
        var pC = Int32.Parse(pedidos.Split(' ')[2]);

        var falta = 0; 
        if(pA > dA)
            falta += pA - dA;
        if(pB > dB)
            falta += pB - dB;
        if(pC > dC)
            falta += pC - dC;
    
        Console.Write("{0}\n", falta);
    }
}