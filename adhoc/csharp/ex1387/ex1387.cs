using System;

class URI
{
    static void Main(string[] args)
    {
        while(true)
        {
            var entradas = Console.ReadLine();
            var n1 = Int32.Parse(entradas.Split(' ')[0]);
            var n2 = Int32.Parse(entradas.Split(' ')[1]);

            if(n1 + n2 == 0)
                break;
 
            Console.Write("{0}\n", n1 + n2);
        }
    }
}