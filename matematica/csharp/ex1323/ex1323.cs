using System;

class URI
{
    static void Main(string[] args)
    {
        while(true)
        {
            var n = Int32.Parse(Console.ReadLine());
            if(n == 0)
                break;

            if(n == 1)
            {
                Console.Write("1\n");
                continue;
            }

            var quadrados = 1;  
            for(int i = n; i > 1; i--)
            {
                quadrados += i * i;
            }

            Console.Write("{0}\n", quadrados);
        }
    }
}