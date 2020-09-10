using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        List<int> valores = new List<int>();
        int a = Int32.Parse(entrada.Split(' ')[0]);
        int b = Int32.Parse(entrada.Split(' ')[1]);
        int c = Int32.Parse(entrada.Split(' ')[2]);
        valores.Add(a);
        valores.Add(b);
        valores.Add(c);

        valores.Sort();

        foreach(var valor in valores)
        {
            Console.Write("{0}\n", valor);
        }

        Console.Write("\n");

        Console.Write("{0}\n", a);
        Console.Write("{0}\n", b);
        Console.Write("{0}\n", c);

    }
}