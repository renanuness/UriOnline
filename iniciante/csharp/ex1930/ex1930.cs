using System;

class URI
{
    static void Main(string[] args)
    {
        string valores = Console.ReadLine();

        var t1 = Int32.Parse(valores.Split(' ')[0]);
        var t2 = Int32.Parse(valores.Split(' ')[1]);
        var t3 = Int32.Parse(valores.Split(' ')[2]);
        var t4 = Int32.Parse(valores.Split(' ')[3]);

        var total = t1 + t2 + t3 + t4;

        Console.Write("{0}\n", total-3);
    }
}