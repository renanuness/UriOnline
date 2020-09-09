using System;

class URI
{
    static void Main(string[] args)
    {
        string valores = Console.ReadLine();
        var A = Int32.Parse(valores.Split(' ')[0]);
        var B = Int32.Parse(valores.Split(' ')[1]);
        var C = Int32.Parse(valores.Split(' ')[2]);

        var maior = 0;

        if(A > B)
        {
            if(A > C)
            {
                maior = A;
            }
            else
            {
                maior = C;
            }
        }
        else
        {
            if(B > C)
            {
                maior = B;
            }
            else
            {
                maior = C;
            }
        }

        Console.Write("{0} eh o maior\n", maior);
    }
}