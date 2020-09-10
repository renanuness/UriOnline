using System;

class URI
{
    static void Main(string[] args)
    {
        var valores = Console.ReadLine();
        var A = Double.Parse(valores.Split(' ')[0]);
        var B = Double.Parse(valores.Split(' ')[1]);
        var C = Double.Parse(valores.Split(' ')[2]);

        var raiz = (B * B) - (4 * A * C);
        if((A == 0) || (B == 0) ||  (C == 0) || ( raiz < 0 ))
        {
            Console.Write("Impossivel calcular\n");
            return;
        }

        raiz = Math.Sqrt(raiz);
        
        var R1 = (-B + raiz) / (2 * A);
        var R2 = (-B - raiz) / (2 * A);

        Console.Write("R1 = {0:f5}\n", R1);
        Console.Write("R2 = {0:f5}\n", R2);
    }
}