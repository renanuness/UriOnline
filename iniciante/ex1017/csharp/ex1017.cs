using System;

class URI
{
    static void Main(string[] args)
    {
        const int CONSUMO_POR_KM = 12;

        var duracaoViagemHoras = Int32.Parse(Console.ReadLine());
        var velocidadeMedia = Int32.Parse(Console.ReadLine());
    
        var distancia = velocidadeMedia * duracaoViagemHoras;

        var consumo = (double)distancia / (double)CONSUMO_POR_KM;

        Console.Write("{0:f3}\n", consumo);
    }
}