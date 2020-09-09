using System;

class URI
{
    static void Main(string[] args)
    {
        var N = Int32.Parse(Console.ReadLine());
        var resultado = ((N+1)*(N+2))/2;
    
        Console.Write("{0}\n",resultado);
    }
}