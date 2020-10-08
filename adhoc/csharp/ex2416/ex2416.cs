using System;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Console.ReadLine();

        var distancia = Int32.Parse(entradas.Split(' ')[0]);
        var tamanhoPista = Int32.Parse(entradas.Split(' ')[1]);
    
        var pontoTermino = distancia % tamanhoPista;
        Console.Write("{0}\n", pontoTermino);
    }
}