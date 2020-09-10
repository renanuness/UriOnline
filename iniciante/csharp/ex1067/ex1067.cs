using System;

class URI
{
    static void Main(string[] args)
    {
        var maximo = Int32.Parse(Console.ReadLine());

        int valor = 1;
        while(valor <= maximo)
        {
            Console.Write("{0}\n", valor);
            valor +=2;
        }
    }
}