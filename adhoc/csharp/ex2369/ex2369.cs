using System;

class URI
{
    static void Main(string[] args)
    {
        var consumo = Int32.Parse(Console.ReadLine());

        int conta = 0;
        if(consumo < 11)
            conta = 7;
        else if(consumo <= 30)
    }
}

public class FaixaConsumo
{
    public int Minimo {get; private set;}
    public int Maximo {get; private set;}
    public int Intervalo {get; private set;}
    public int Taxa {get;private set;}

    public FaixaConsumo(int minimo, int maximo, int taxa)
    {
        Minimo = minimo;
        Maximo = maximo;
        Intervalo = Maximo - (Minimo -1);
        Taxa = taxa;
    }

    public bool InclusoNaFaixa(int consumo)
    {
        if(consumo <= Maximo && consumo >= Minimo)
            return true;

        return false;
    }
}