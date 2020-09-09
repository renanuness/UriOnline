using System;

class Uri
{
    static void Main(string[] args)
    {
        string produto1 = Console.ReadLine();
        int codigo1 = Int32.Parse(produto1.Split(' ')[0]);
        int quantidade1 = Int32.Parse(produto1.Split(' ')[1]);
        double preco1 = Double.Parse(produto1.Split(' ')[2]);

        string produto2 = Console.ReadLine();
        int codigo2 = Int32.Parse(produto2.Split(' ')[0]);
        int quantidade2 = Int32.Parse(produto2.Split(' ')[1]);
        double preco2 = Double.Parse(produto2.Split(' ')[2]);

        var total = (quantidade1 * preco1) + (quantidade2 * preco2);

        Console.Write("VALOR A PAGAR: R$ {0:f2}\n", total);
    }
}