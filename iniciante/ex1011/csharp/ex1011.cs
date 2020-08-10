using System;

class Uri
{
    static void Main(string[] args)
    {
        const double quatroSobreTres = 4/3D;
        const double PI = 3.14159D;
        var raio = Double.Parse(Console.ReadLine());
        var volume = quatroSobreTres * PI * Math.Pow(raio, 3);

        Console.Write("VOLUME = {0:f3}\n",volume    );
    }
}