using System;

class URI
{
    static void Main(string[] args)
    {
        Impressora impressora = new Impressora();
        impressora.ImprimirTudo();
    }
}

public class Impressora
{
    private void ImprimirLinha()
    {
        for(int i = 0; i < 39; i++)
            Console.Write("-");

        Console.Write("\n");
    }

    private void ImprimirLaterais()
    {
        Console.Write("|");

        for(int i = 0; i < 37; i++)
            Console.Write(" ");

        Console.Write("|");
        
        Console.Write("\n");
    }

    public void ImprimirTudo()
    {
        ImprimirLinha();
        ImprimirLaterais();
        ImprimirLaterais();
        ImprimirLaterais();
        ImprimirLaterais();
        ImprimirLaterais();
        ImprimirLinha();
    }
}