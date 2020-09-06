using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        List<int> tempos = new List<int>();
        string valores = Console.ReadLine();
        
        tempos.Add(Int32.Parse(valores.Split(' ')[0]));
        tempos.Add(Int32.Parse(valores.Split(' ')[1]));
        tempos.Add(Int32.Parse(valores.Split(' ')[2]));

        tempos.Sort();

        if(Calculadora.DoisIguais(tempos) || Calculadora.SomaDeDois(tempos))
            Console.Write("S\n");
        else
            Console.Write("N\n");
    }
}

public static class Calculadora
{
    public static bool DoisIguais(List<int> valores)
    {
        if(valores[0] == valores[1] || valores[0] == valores[2] || valores[1] == valores[2])
            return true;

        return false;
    }

    public static bool SomaDeDois(List<int> valores)
    {
        if(valores[0] + valores[1] == valores[2])
            return true;

        return false;
    }
}