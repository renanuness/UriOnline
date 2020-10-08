using System;

class URI
{
    static void Main(string[] args)
    {
        var quantidadeDeIntervalos = Int32.Parse(Console.ReadLine());

        var distanciaTotal = 0;

        while(quantidadeDeIntervalos-- > 0)
        {
            var entradas = Console.ReadLine();
            var tempo = Int32.Parse(entradas.Split(' ')[0]);
            var velocidade = Int32.Parse(entradas.Split(' ')[1]);
            distanciaTotal += velocidade*tempo;
        }

        Console.Write("{0}\n", distanciaTotal);
    }
}