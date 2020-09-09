using System;

class URI
{
    static void Main(string[] args)
    {
        string valores = Console.ReadLine();

        var inicio = Int32.Parse(valores.Split(' ')[0]);
        var fim = Int32.Parse(valores.Split(' ')[1]);

        if(inicio >= fim)
        {
            fim += 24;
        }

        var duracao = fim - inicio;

        Console.Write("O JOGO DUROU {0} HORA(S)\n", duracao);
    }
}