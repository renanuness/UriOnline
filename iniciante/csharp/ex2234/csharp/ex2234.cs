using System;

class URI
{
    static void Main(string[] args)
    {
        string valores = Console.ReadLine();
        int hotDogs = Int32.Parse(valores.Split(' ')[0]);
        int pessoas = Int32.Parse(valores.Split(' ')[1]);
    
        var resultado = (double)hotDogs/(double)pessoas;

        Console.Write("{0:f2}\n", resultado);
    }
}