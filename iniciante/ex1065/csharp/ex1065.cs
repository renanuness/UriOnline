using System;

class URI
{
    static void Main(string[] args)
    {
        int ENTRADAS = 5;
        var pares = 0;

        while(ENTRADAS-- > 0)
        {
            if(Int32.Parse(Console.ReadLine()) % 2 == 0) pares++;
        }

        Console.Write("{0} valores pares\n", pares);
    }
}