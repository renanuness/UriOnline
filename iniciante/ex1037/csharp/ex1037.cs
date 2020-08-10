using System;

class URI
{
    static void Main(string[] args)
    {
        var valor = float.Parse(Console.ReadLine());

        if(valor >= 0 && valor <= 25)
            Console.Write("Intervalo [0,25]\n");

        if(valor > 25 && valor <= 50)
            Console.Write("Intervalo (25,50]\n");

        if(valor > 50 && valor <= 75)
            Console.Write("Intervalo (50,75]\n");

        if(valor > 75 && valor <= 100)
            Console.Write("Intervalo (75,100]\n");
        if(valor < 0 || valor > 100)                
            Console.Write("Fora de intervalo\n");
    }
}