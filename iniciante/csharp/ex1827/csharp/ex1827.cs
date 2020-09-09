using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        Print print = new Print();
        print.LerValores();
        print.ImprimirMatrizes();
    }
}

public class Print
{
    public List<int> Valores {get; private set;}
    public int Tamanho {get; private set;}
    private int UltimaPosicao;

    public Print()
    {
        Valores = new List<int>();
    }

    public void LerValores()
    {
        while(LerValor())
        {}
    }

    private bool LerValor()
    {
        string entrada = Console.ReadLine();
        if(string.IsNullOrEmpty(entrada))
            return false;

        Valores.Add(Int32.Parse(entrada));
        return true;
    }

    public void ImprimirMatrizes()
    {
        foreach(var valor in Valores)
        {
            ImprimirMatriz(valor);
            Console.Write("\n");
        }
    }

    private void ImprimirMatriz(int tamanho)
    {
        ConfiguraValores(tamanho);
        for(int i = 0; i < tamanho; i++)
        {
            for(int j = 0; j < tamanho; j++)
            {
                if(EhCentro(i, j))
                    Console.Write("4");
                if(EhQuadradoInterno(i, j))
                    Console.Write("1");
                if(EhDiagonal(i, j))
                    Console.Write("2");
                if(EhDiagonalSecundaria(i, j))
                    Console.Write("3");
                if(EhParteExterna(i, j))
                    Console.Write("0");
            }
            Console.Write("\n");
        }
    }

    public void ConfiguraValores(int tamanho)
    {
        UltimaPosicao = tamanho - 1;
        Tamanho = tamanho;
    }

    public bool EhParteExterna(int linha, int coluna)
    {
        if(EhCentro(linha, coluna))
            return false;

        if(EhQuadradoInterno(linha, coluna))
            return false;
        
        if(EhDiagonal(linha, coluna))
            return false;
        
        if(EhDiagonalSecundaria(linha, coluna))
            return false;

        return true;
    }

    public bool EhDiagonal(int linha, int coluna)
    {
        if(EhCentro(linha, coluna))
            return false;
        
        if(EhQuadradoInterno(linha, coluna))
            return false;

        if(linha == coluna)
           return true;

        return false;
    }

    public bool EhDiagonalSecundaria(int linha, int coluna)
    {
        if(EhQuadradoInterno(linha, coluna))
            return false;
            
        if(EhCentro(linha, coluna))
            return false;
        
        if(linha + coluna == UltimaPosicao)
            return true;
        
        return false;
    }

    public bool EhQuadradoInterno(int linha, int coluna)
    {
        if(EhCentro(linha, coluna))
            return false;

        int comeco = Tamanho / 3;
        int fim = UltimaPosicao - comeco;
        if((coluna >= comeco && coluna <= fim) && (linha >= comeco && linha <= fim))
            return true;
        
        return false;
    }

    public bool EhCentro(int linha, int coluna)
    {
        if(linha == Tamanho/2 && coluna == Tamanho/2)
            return true;

        return false;
    }
}