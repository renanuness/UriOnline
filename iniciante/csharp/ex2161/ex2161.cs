using System;

class URI
{
    static void Main(string[] args)
    {
        int repeticoes = Int32.Parse(Console.ReadLine());

        var resultado = 3 + Calcular(repeticoes);
        
        Console.Write("{0:f10}\n", resultado);
    }

    static Double Calcular(int repeticoes)
    {
        if(repeticoes == 0)
            return 0;

        return 1/(6 + Calcular(--repeticoes));
    }
}