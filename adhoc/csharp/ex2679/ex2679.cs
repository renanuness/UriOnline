using System;

class URI
{
    static void Main(string[] args)
    {
        int valor = Int32.Parse(Console.ReadLine());


        if(valor % 2 == 0)
            Console.Write("{0}\n", valor+2);
        else
            Console.Write("{0}\n", valor+1);

    }
}