using System;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Console.ReadLine();
        var cv = Int32.Parse(entradas.Split(' ')[0]);
        var ce = Int32.Parse(entradas.Split(' ')[1]);
        var cs = Int32.Parse(entradas.Split(' ')[2]);
        var fv = Int32.Parse(entradas.Split(' ')[3]);
        var fe = Int32.Parse(entradas.Split(' ')[4]);
        var fs = Int32.Parse(entradas.Split(' ')[5]);
        
        var corinthians = new Time(cv, ce, cs, "C");
        var flamengo = new Time(fv, fe, fs, "F");
    
        var vencedor = CompararPontos(corinthians, flamengo);
        if(vencedor != null)
            Console.Write("{0}\n",vencedor.Letra);
        else
            Console.Write("=\n");

    }

    public static Time CompararPontos(Time a, Time b)
    {
        if(a.Pontuacao > b.Pontuacao)
            return a;
        else if(a.Pontuacao < b.Pontuacao)
            return b;
        else
            return CompararSaldo(a, b);
    }

    public static Time CompararSaldo(Time a, Time b)
    {
        if(a.Saldo > b.Saldo)
            return a;
        else if(b.Saldo > a.Saldo)
            return b;

        return null;
    }
}

public class Time
{
    public int Vitorias {get; private set;}
    public int Empates {get; private set;}
    public int Saldo {get; private set;}
    public int Pontuacao {get; private set;}
    public string Letra { get; private set;}

    public Time(int v, int e, int s, string l)
    {
        Vitorias = v;
        Empates = e;
        Saldo = s;
        Pontuacao = (Vitorias * 3) + Empates;
        Letra = l;
    }


}