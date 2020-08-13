using System;

class URI
{
    static void Main(string[] args)
    {
        var a = 234.345D;
        var b = 45.698D;

        Console.Write("{0:f6} - {1:f6}\n", a, b);
        Console.Write("{0:f0} - {1:f0}\n", a, b);
        Console.Write("{0:f1} - {1:f1}\n", a, b);
        Console.Write("{0:f2} - {1:f2}\n", Math.Truncate(100*a)/100, b);
        Console.Write("{0:f3} - {1:f3}\n", a, b);
        Console.Write("{0:0.#####0e+00} - {1:0.####00e+00}\n", a, b);
        Console.Write("{0:0.#####0E+00} - {1:0.####00E+00}\n", a, b);
        Console.Write("{0:0.###} - {1:0.###}\n", a, b);
        Console.Write("{0:0.###} - {1:0.###}\n", a, b);
    }
}

