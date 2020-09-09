using System;

class Uri
{
    static void Main(string[] args)
    {
        const double pesoA = 3.5;
        const double pesoB = 7.5;
        const double total = pesoA + pesoB;
        var A = Double.Parse(Console.ReadLine());
        var B = Double.Parse(Console.ReadLine());

        var MEDIA = A * (pesoA/total) + B * (pesoB/total);

        Console.Write("MEDIA = {0:f5}\n",MEDIA);
    }
}