using System;

class URI
{
    static void Main(string[] args)
    {
        string [] valores = Console.ReadLine().Split(' ');

        var a = Int32.Parse(valores[0]);
        var b = -1;
        int index = 1;
        while(b <= 0)
        {
            b = Int32.Parse(valores[index++]);
        }
        
        int aInicial = a;
        for(int i = 1; i < b; i++)
        {
            a += ++aInicial;    
        }

        Console.Write("{0}\n", a);
    }
}