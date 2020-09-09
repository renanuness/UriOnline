using System;

class URI
{
    static void Main(string[] args)
    {
        var pontos = Console.ReadLine();
        var x = Double.Parse(pontos.Split(' ')[0]);
        var y = Double.Parse(pontos.Split(' ')[1]);

        if(x == y && y == 0)
        {
            Console.Write("Origem\n");
            return;
        }
        
        if(x == 0)
        {
            Console.Write("Eixo Y\n");
            return;
        }

        if(y == 0)
        {
            Console.Write("Eixo X\n");
            return;
        }

        if(x > 0)
        {
            if(y > 0)
                Console.Write("Q1\n");
            else
                Console.Write("Q4\n");
        }
        else
        {
            if(y > 0)
                Console.Write("Q2\n");
            else
                Console.Write("Q3\n");
        }
    }
}