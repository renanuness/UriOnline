using System;

class URI
{
    static void Main(string[] args)
    {
        int distancia = Int32.Parse(Console.ReadLine());

        if(distancia <= 800)
        {
            Console.Write("1\n");
        }
        else if(distancia > 800 && distancia <= 1400)
        {
            Console.Write("2\n");

        }
        else if(distancia > 1400)
        {
            Console.Write("3\n");
        }
    }
}