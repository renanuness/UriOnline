using System;

class URI
{
    static void Main(string[] args)
    {
        var A = Int32.Parse(Console.ReadLine());
        var B = Int32.Parse(Console.ReadLine());

        ColocaMenorNoA(ref A, ref B);

        var somaDivisiveisPorTreze = 0;

        while(A <= B){
            if(A % 13 != 0)
                somaDivisiveisPorTreze += A;

            A++;
        }
        
        Console.Write("{0}\n", somaDivisiveisPorTreze);
    }

    static void ColocaMenorNoA(ref int a, ref int b)
    {
        if(a < b)
            return;

        var temp = b;
        b = a;
        a = temp;
    }
}