using System;

class URI
{
    static void Main(string[] args)
    {
        var L = Int32.Parse(Console.ReadLine());
        var C = Int32.Parse(Console.ReadLine());

        var dois = ((L-1) + (C-1))* 2;
        var um = L*C + ((C-1)*(L-1));

        Console.Write("{0}\n", um);
        Console.Write("{0}\n", dois);
    }
}