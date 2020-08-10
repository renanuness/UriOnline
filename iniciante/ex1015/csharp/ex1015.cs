using System;

class URI
{
    static void Main(string[] args)
    {
        string p1 = Console.ReadLine();
        string p2 = Console.ReadLine();

        var x1 = Double.Parse(p1.Split(' ')[0]);
        var y1 = Double.Parse(p1.Split(' ')[1]);

        var x2 = Double.Parse(p2.Split(' ')[0]);
        var y2 = Double.Parse(p2.Split(' ')[1]);

        var resultado = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);

        resultado = Math.Sqrt(resultado);

        Console.Write("{0:f4}\n",resultado);
    }
}