using System;

class URI
{
    static void Main(string[] args)
    {
        var opcoes = Int32.Parse(Console.ReadLine());

        var menorValor = double.MaxValue;
        while(opcoes-- > 0)
        {
            var entrada = Console.ReadLine();

            var preco = double.Parse(entrada.Split(' ')[0]);
            var peso = Int32.Parse(entrada.Split(' ')[1]);
        
            var valorKilo = (1000/(double)peso) * preco;
            menorValor = menorValor > valorKilo ? valorKilo : menorValor;
        }

        Console.Write("{0:f2}\n", menorValor);
    }
}