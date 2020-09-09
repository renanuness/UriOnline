using System;

class URI
{
    static void Main(string[] args)
    {
        var quantidadeEntradas = Int32.Parse(Console.ReadLine());
        var entreDezVinte = 0;
        var menorDezMaiorVinte = 0;
        while(quantidadeEntradas-- > 0)
        {
            var valor = Int32.Parse(Console.ReadLine());
            if(valor>= 10 && valor <= 20) 
                entreDezVinte++;
            else
                menorDezMaiorVinte++;
        }

        Console.Write("{0} in\n", entreDezVinte);
        Console.Write("{0} out\n", menorDezMaiorVinte);
    }
}