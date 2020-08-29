using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        double salario = double.Parse(Console.ReadLine());
        CalculadoraImposto calculadora = new CalculadoraImposto();
        calculadora.DefinirSalario(salario);
        calculadora.ImprimirImposto();
    }
}

public class CalculadoraImposto
{
    public List<FaixaDeImposto> faixasDeImposto{get; private set;}
    public double Salario {get; private set;}

    public CalculadoraImposto()
    {
        faixasDeImposto = new List<FaixaDeImposto>();
        PreencherfaixasDeImposto();
    }

    public void DefinirSalario(double salario)
    {
        if(salario > 0)
            Salario = salario;
    }
    
    private void PreencherfaixasDeImposto()
    {
        faixasDeImposto.Add(new FaixaDeImposto(4500, Double.MaxValue, 28));
        faixasDeImposto.Add(new FaixaDeImposto(3000.01, 4500, 18));
        faixasDeImposto.Add(new FaixaDeImposto(2000.01, 3000, 8));
        faixasDeImposto.Add(new FaixaDeImposto(0, 2000, 0));
    }

    private double CalcularImposto()
    {
        double salario = Salario;
        double imposto = 0;
        foreach(var valor in faixasDeImposto)
        {
            if(Salario > valor.ValorMinimo)
            {
                double tributavel = salario - valor.ValorMinimo;
                imposto += valor.Calcular(tributavel);
                salario -= tributavel;
            }
        }
        return imposto; 
    }

    public void ImprimirImposto()
    {
        var imposto = CalcularImposto();
        if(imposto == 0)
        {
            Console.Write("Isento\n");
            return;
        }
        Console.Write("R$ {0:f2}\n", imposto);
    }
}

public class FaixaDeImposto
{
    public double ValorMinimo{get; private set;}
    public double ValorMaximo{get; private set;}
    public int Imposto{get; private set;}

    public FaixaDeImposto(double valorMinimo, double valorMaximo, int imposto)
    {
        ValorMinimo = valorMinimo;
        ValorMaximo = valorMaximo; 
        Imposto = imposto;
    }

    public double Calcular(double valor)
    {
        return Math.Round((valor * Imposto)/100,2);
    } 
}