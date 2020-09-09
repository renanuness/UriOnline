using System;

class Uri
{
    static void Main(string[] args)
    {
        const double pesoA = 2;
        const double pesoB = 3;
        const double pesoC = 5;
        const double total = pesoA + pesoB + pesoC;

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        var MEDIA = A * (pesoA/total) + B * (pesoB/total) + C * (pesoC/total);

        Console.Write("MEDIA = {0:f1}\n",MEDIA); 
    }
}