using System;

class URI
{
    static void Main(string[] args)
    {
        Programa programa = new Programa();
        programa.Imprimir();
    }
}

public class Programa
{
    public void Imprimir()
    {
        DesenharLinhaHorizontal();
        SegundaLinha();
        DesenharLinhaHorizontal();
        ImprimirNumeros();
        DesenharLinhaHorizontal();
    }

    public void DesenharLinhaHorizontal()
    {
        for(int i = 0; i < 39; i++)
            Console.Write("-");

        Console.Write("\n");
    }

    public void SegundaLinha()
    {
        Console.Write("|  decimal  |  octal  |  Hexadecimal  |\n");
    }

    public void ImprimirNumeros()
    {
        for(int i = 0; i < 16; i++)
        {
            if(i < 8)
                Console.Write("|      {0}    |    {1}    |       {2}       |\n", i, Convert.ToString(i, 8), i.ToString("X"));
            if(i >= 8 && i < 10)
                Console.Write("|      {0}    |   {1}    |       {2}       |\n", i, Convert.ToString(i, 8), i.ToString("X"));
            if(i >= 10)
                Console.Write("|     {0}    |   {1}    |       {2}       |\n", i, Convert.ToString(i, 8), i.ToString("X"));
        }
    }
}