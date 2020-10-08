using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        var calculadora = new CalculadoraContaAgua();
        calculadora.LerConsumo();
        calculadora.CalcularConta();
        calculadora.ImprimirConta();
    }
}

public class CalculadoraContaAgua
{
    public int ValorConta {get; private set;}
    public int ConsumoAgua {get; private set;}
    public List<FaixaConsumo> FaixasConsumo {get; private set;}

    public void LerConsumo()
    {
        PreencherFaixasConsumo();
        ConsumoAgua = Int32.Parse(Console.ReadLine());
    }

    public void CalcularConta()
    {
        var consumoNaoContabilizado = ConsumoAgua;

        ValorConta = 7;
        foreach(var faixaConsumo in FaixasConsumo)
        {
            if(consumoNaoContabilizado > faixaConsumo.Minimo)
            {
                var excedente = consumoNaoContabilizado - faixaConsumo.Minimo;
                consumoNaoContabilizado -= excedente;
                ValorConta += excedente * faixaConsumo.Taxa;
            }
        }
    }

    public void ImprimirConta()
    {
        Console.Write("{0}\n", ValorConta);
    }
    public void PreencherFaixasConsumo()
    {
        FaixasConsumo = new List<FaixaConsumo>();
        FaixasConsumo.Add(new FaixaConsumo(100, Int32.MaxValue, 5));
        FaixasConsumo.Add(new FaixaConsumo(30, 100, 2));
        FaixasConsumo.Add(new FaixaConsumo(10, 30, 1));
        FaixasConsumo.Add(new FaixaConsumo(0, 10, 0));
    }
}

public class FaixaConsumo
{
    public int Minimo {get; private set;}
    public int Maximo {get; private set;}
    public int Taxa {get;private set;}

    public FaixaConsumo(int minimo, int maximo, int taxa)
    {
        Minimo = minimo;
        Maximo = maximo;
        Taxa = taxa;
    }
}

