using System;

class URI
{
    static void Main(string[] args)
    {
        double N = 0;
        do{
            N = Double.Parse(Console.ReadLine());
        }while(N < 0 || N > 1000000);

        double centavos = N - (int)N;
        double original = N - centavos;


        int notasCem = (int)(N / 100);
        N = N % 100;
        
        int notasCinquenta = (int)(N / 50);
        N = N % 50;
        
        int notasVinte = (int)(N / 20);
        N = N % 20;
        
        int notasDez = (int)(N / 10);
        N = N % 10;

        int notasCinco = (int)(N / 5);
        N = N % 5;

        int notasDois = (int)(N / 2);
        N = N % 2;
        
        int moedasUm = (int)N;

        centavos *= 100;
        int moedasCinquenta = (int)(centavos / 50);
        centavos = centavos % 50;

        int moedasVinteCinco = (int)(centavos / 25);
        centavos = centavos % 25;

        int moedasDez = (int)(centavos / 10);
        centavos = centavos % 10;

        int moedasCinco = (int)(centavos / 5);
        centavos = centavos % 5;

        Console.Write("NOTAS:\n");
        Console.Write("{0} nota(s) de R$ 100.00\n", notasCem);
        Console.Write("{0} nota(s) de R$ 50.00\n", notasCinquenta);
        Console.Write("{0} nota(s) de R$ 20.00\n", notasVinte);
        Console.Write("{0} nota(s) de R$ 10.00\n", notasDez);
        Console.Write("{0} nota(s) de R$ 5.00\n", notasCinco);
        Console.Write("{0} nota(s) de R$ 2.00\n", notasDois);
        
        Console.Write("MOEDAS:\n");
        Console.Write("{0} moeda(s) de R$ 1.00\n", moedasUm);
        Console.Write("{0} moeda(s) de R$ 0.50\n", moedasCinquenta);
        Console.Write("{0} moeda(s) de R$ 0.25\n", moedasVinteCinco);
        Console.Write("{0} moeda(s) de R$ 0.10\n", moedasDez);
        Console.Write("{0} moeda(s) de R$ 0.05\n", moedasCinco);
        Console.Write("{0} moeda(s) de R$ 0.01\n", (int)centavos);

    }
}