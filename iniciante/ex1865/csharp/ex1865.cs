using System;

class URI
{
    static void Main(string[] args)
    {
        int c = Int32.Parse(Console.ReadLine());

        while(c-- > 0)
        {
            string entrada = Console.ReadLine();

            if(entrada.Contains("Thor"))
                Console.Write("Y\n");
            else
                Console.Write("N\n");
        }
    }
}