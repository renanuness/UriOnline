using System;

class URI
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_NUMEROS = 6;

        double soma = 0;
        double quantidadePositivos = 0;
        for(int i = 0; i < QUANTIDADE_NUMEROS; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            if(valor > 0)
            {
                soma += valor;
                quantidadePositivos++;
            }
        }

        Console.Write("{0} valores positivos\n", quantidadePositivos);
        Console.Write("{0:f1}\n", soma/quantidadePositivos);
    }
}