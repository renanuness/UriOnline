using System;

class URI
{
    static void Main(string[] args)
    {
        var valores = Console.ReadLine();
        var A = Int32.Parse(valores.Split(' ')[0]);
        var B = Int32.Parse(valores.Split(' ')[1]);
        var C = Int32.Parse(valores.Split(' ')[2]);
        var D = Int32.Parse(valores.Split(' ')[3]);

        if((B.EhMaiorQue(C) && D.EhMaiorQue(A))
            && ((C + D).EhMaiorQue(A + B))
            && (C.EhMaiorQue(0) && D.EhMaiorQue(0))
            && (A.EhPar()))
        {
            Console.Write("Valores aceitos\n");
        }
        else
        {
            Console.Write("Valores nao aceitos\n");
        }
    }
} 

public static class Testes
{
    public static bool EhMaiorQue(this int A, int B)
    {
        return A > B;
    }

    public static bool EhPar(this int value)
    {
        return value % 2 == 0;
    }
}