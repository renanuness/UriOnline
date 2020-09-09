using System;

class URI
{
    static void Main(string[] args)
    {
        int A = Int32.Parse(Console.ReadLine());
        int M = Int32.Parse(Console.ReadLine());

        var resultado = (M * 2) - A;
    
        Console.Write("{0}\n", resultado);
    }
}