using System;

class URI
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());

        Print print = new Print(n);

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(print.EhParteExterna(i, j))
                    Console.Write("0");
                else
                    Console.Write("1");
            }
            Console.Write("\n");
        }
    }
}

public class Print
{
    public int Tamanho {get; private set;}
    
    public Print(int tamanho)
    {
        Tamanho = tamanho;
    }

    public bool EhParteExterna(int linha, int coluna)
    {
        if(linha == 0 && coluna != 0)
            return true;

        if(linha != 0 && coluna == 0)
            return true;

        if(linha == Tamanho-1 && coluna != Tamanho -1)
            return true;
        
        if(coluna == Tamanho-1 && linha != Tamanho -1)
            return true;
    
        return false;
    }

    public bool EhQuadradoInterno(int linha, int coluna)
    {
        if(coluna > Tamanho/3 && coluna < Tamanho)

    }
}