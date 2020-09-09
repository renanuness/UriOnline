using System;

class URI
{
    static void Main(string[] args)
    {
        int N = 0;
        do{
            N = Int32.Parse(Console.ReadLine());
        }while(N < 0 || N > 1000000);

        int original = N;

        var notasCem = N / 100;
        N = N % 100;
        
        var notasCinquenta = N / 50;
        N = N % 50;
        
        var notasVinte = N / 20;
        N = N % 20;
        
        var notasDez = N / 10;
        N = N % 10;

        var notasCinco = N / 5;
        N = N % 5;

        var notasDois = N / 2;
        N = N % 2;
        
        Console.Write("{0}\n",original);
        Console.Write("{0} nota(s) de R$ 100,00\n", notasCem);
        Console.Write("{0} nota(s) de R$ 50,00\n", notasCinquenta);
        Console.Write("{0} nota(s) de R$ 20,00\n", notasVinte);
        Console.Write("{0} nota(s) de R$ 10,00\n", notasDez);
        Console.Write("{0} nota(s) de R$ 5,00\n", notasCinco);
        Console.Write("{0} nota(s) de R$ 2,00\n", notasDois);
        Console.Write("{0} nota(s) de R$ 1,00\n", N);
    }
}