using System;

class Uri
{
    static void Main(string[] args)
    {
        var A = Int32.Parse(Console.ReadLine());
        var B = Int32.Parse(Console.ReadLine());
        var C = Int32.Parse(Console.ReadLine());
        var D = Int32.Parse(Console.ReadLine());
    
        var DIFERENCA = A * B - C * D;
        Console.Write("DIFERENCA = {0}\n", DIFERENCA);
    }
}