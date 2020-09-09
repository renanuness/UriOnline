using System;

class URI{
    static void Main(string[] args)
    {
        const double N = 3.14159D;
        double raio = double.Parse(Console.ReadLine());

        double area = N * raio * raio;
        Console.Write("A={0:f4}\n", area);
    }
}