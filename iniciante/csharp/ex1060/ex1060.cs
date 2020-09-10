using System;


class URI
{
    static void Main(string[] args)
    {
        const int quantidadeInput = 6;

        double[] valores = new double[quantidadeInput];
        int numerosPositivos = 0;
        for(int i = 0; i < quantidadeInput; i++)
        {
            valores[i] = Double.Parse(Console.ReadLine());
            if(valores[i] > 0) numerosPositivos++;
        }

        Console.Write("{0} valores positivos\n", numerosPositivos);
    }
}