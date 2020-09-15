using System;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Int32.Parse(Console.ReadLine());

        decimal soma = 0;
        while(entradas-- > 0)
        {
            var entrada = Console.ReadLine();
            var codigo = Int32.Parse(entrada.Split(' ')[0]);
            var quantidade = Int32.Parse(entrada.Split(' ')[1]);
            
            decimal valor = 0.5M;
            codigo -= 1000;
            valor += codigo;
            soma += valor * (decimal)quantidade;
        }

        Console.Write("{0:f2}\n", soma);
    }
}