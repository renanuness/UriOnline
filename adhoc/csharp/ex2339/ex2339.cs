using System;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Console.ReadLine();

        var competidores = Int32.Parse(entradas.Split(' ')[0]);
        var folhas = Int32.Parse(entradas.Split(' ')[1]);
        var tentativas = Int32.Parse(entradas.Split(' ')[2]);
    
        var resultado = tentativas * competidores > folhas ? "N" : "S";

        Console.Write("{0}\n", resultado);
    }
}