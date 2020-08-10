using System;

class URI
{
    static void Main(string[] args)
    {
        var X = Int32.Parse(Console.ReadLine());
        var Y = Double.Parse(Console.ReadLine());

        var consumo = X/Y;

        Console.Write("{0:f3} km/l\n",consumo); 
    }
}