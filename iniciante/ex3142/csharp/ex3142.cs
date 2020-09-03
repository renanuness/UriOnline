using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        Coluna coluna = new Coluna();
        coluna.LerValor();
        coluna.CalcularColunas();
    }
}

public class Coluna
{
    public string Nome{get; private set;}
    public List<string> Colunas {get; private set;}

    public Coluna()
    {
        Colunas = new List<string>();
    }
    public void LerValor()
    {
        while(EntradaValida())
        {
        }
    }

    private bool EntradaValida()
    {
        Nome = Console.ReadLine();
        if(string.IsNullOrEmpty(Nome))
            return false;

        Colunas.Add(Nome);
        return true;
    }

    public bool EhValida(int valor)
    {
        if(valor >= 1 && valor <= 16384)
            return true;

        return false;
    }

    public void CalcularColunas()
    {
        foreach(var coluna in Colunas)
        {
            int valor = Calcular(coluna);
            if(EhValida(valor))
                Console.Write("{0}\n", valor);
            else
                Console.Write("Essa coluna nao existe Tobias!\n");
        }
    }

    public int Calcular(string coluna)
    {
        int valor = 0;
        for(int i = coluna.Length-1; i >= 0; i--)
        {
            valor += CalculcarValorLetra(coluna[i], (coluna.Length-1)-i);
        }
        return valor;
    }

    private int CalculcarValorLetra(char letra, int index)
    {
        int baseN = (int)('Z'-'A') +1;

        int valor = (int)letra - 64;
        return valor * (int)(Math.Pow(baseN, index));
    }
}