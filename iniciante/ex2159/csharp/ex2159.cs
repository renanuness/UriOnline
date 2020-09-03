using System;

class URI
{
    static void Main(string[] args)
    {
        var n = double.Parse(Console.ReadLine());
        var ln = Math.Log(n);

        Console.Write("{0:f1} ", n/ln);
        Console.Write("{0:f1}\n", 1.25506*(n/ln));
    }
}