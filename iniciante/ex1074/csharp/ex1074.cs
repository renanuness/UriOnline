using System;

class URI
{
    static void Main(string[] args)
    {
        int casosDeTeste = Int32.Parse(Console.ReadLine());

        while(casosDeTeste-- > 0)
        {
            int valor = Int32.Parse(Console.ReadLine());

            if(valor == 0)
            {
                Console.Write("NULL\n");
                continue;
            }

            if(valor > 0 && valor % 2 == 0)
            {
                Console.Write("EVEN POSITIVE\n");
                continue;
            }

            if(valor > 0 && valor % 2 != 0)
            {
                Console.Write("ODD POSITIVE\n");
                continue;
            }

            if(valor < 0 && valor % 2 == 0)
            {
                Console.Write("EVEN NEGATIVE\n");
                continue;
            }

            if(valor < 0 && valor % 2 != 0)
            {
                Console.Write("ODD NEGATIVE\n");
                continue;
            }
        }
    }
}