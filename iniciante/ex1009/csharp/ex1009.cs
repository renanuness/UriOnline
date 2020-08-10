using System;

class Uri
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        double salario = Double.Parse(Console.ReadLine());
        double vendas = Double.Parse(Console.ReadLine());

        double total = vendas * 0.15 + salario;

        Console.Write("TOTAL = R$ {0:f2}\n", total);
    }
}