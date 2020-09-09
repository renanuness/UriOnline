using System;

class URI
{
    static void Main(string[] args)
    {
        int repeticoes = Int32.Parse(Console.ReadLine());

        var resultado = 1 + Calcular(repeticoes);
        
        Console.Write("{0:f10}\n", resultado);
    }

    static Double Calcular(int repeticoes)
    {
        if(repeticoes == 0)
            return 0;

        return 1/(2 + Calcular(--repeticoes));
    }
}