using System;

class URI
{
    static void Main(string[] args)
    {
        var desenho = new Desenho();
        desenho.DesenharLinhaHorizontal();
        desenho.DesenharSegundaLinha();
        desenho.DesenharLinhaEmBranco();
        desenho.DesenharQuartaLinha();
        desenho.DesenharLinhaEmBranco();
        desenho.DesenharSextaLinha();
        desenho.DesenharLinhaHorizontal();
    }
}

public class Desenho
{
    public void DesenharLinhaHorizontal()
    {
        for(int i = 0; i < 39; i++)
            Console.Write("-");

        Console.Write("\n");
    }

    public void DesenharSegundaLinha()
    {
        string roberto = "Roberto";
        for(int i = 0; i < 39; i++)
        {
            if(i==0 || i ==38)
                DesenharTraco();
            else if(i >= 9 && i < 9 + roberto.Length)
                Console.Write("{0}", roberto[i-9]);
            else
                Console.Write(" ");
        }
        Console.Write("\n");
    }

    public void DesenharQuartaLinha()
    {
        string numeros = "5786";
        for(int i = 0; i < 39; i++)
        {
            if(i==0 || i ==38)
                DesenharTraco();
            else if(i >= 9 && i < 9 + numeros.Length)
                Console.Write("{0}", numeros[i-9]);
            else
                Console.Write(" ");
        }
        Console.Write("\n");
    }

    public void DesenharSextaLinha()
    {
        string unifei = "UNIFEI";
        for(int i = 0; i < 39; i++)
        {
            if(i==0 || i ==38)
                DesenharTraco();
            else if(i >= 9 && i < 9 + unifei.Length)
                Console.Write("{0}", unifei[i-9]);
            else
                Console.Write(" ");
        }
        Console.Write("\n");
    }

    public void DesenharLinhaEmBranco()
    {
        for(int i = 0; i < 39; i++)
        {
            if(i==0 || i ==38)
                DesenharTraco();
            else
                Console.Write(" ");
        }
        Console.Write("\n");
    }
                
    private void DesenharTraco() => Console.Write("|");
}