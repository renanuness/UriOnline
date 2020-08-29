using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {

        var salario = double.Parse(Console.ReadLine());

        Calculadora calculadora = new Calculadora(salario);
        calculadora.ImprimirResultado();
        //Novo salario: 460.00
        //Reajuste ganho: 60.00
        //Em percentual: 15 %
    }
}

public class Calculadora
{
    private const double SALARIO_MINIMO = 400;
    Dictionary<int, double> faixasReajuste = new Dictionary<int, double>();
    public double Salario {get; private set;}

    public Calculadora(double salario )
    {
        Salario = salario;

        faixasReajuste.Add(0, 15);
        faixasReajuste.Add(1, 12);
        faixasReajuste.Add(2, 10);
        faixasReajuste.Add(3, 7);
        faixasReajuste.Add(4, 7);
        faixasReajuste.Add(5, 4);
    }

    private int SalariosMinimos()
    {
        var salariosMinimos = (int)(Salario / SALARIO_MINIMO);
        if((Salario % SALARIO_MINIMO) == 0)
            salariosMinimos--;

        return salariosMinimos;
    }
    
    public double ObterPorcentagemReajuste()
    {
        int salariosMinimos = SalariosMinimos();
        if(salariosMinimos > faixasReajuste.Count-1)
            salariosMinimos = faixasReajuste.Count-1;

        var faixaReajuste = faixasReajuste[salariosMinimos];
        return faixaReajuste;
    }

    public double CalcularReajuste()
    {
        var reajustePorcentagem = ObterPorcentagemReajuste() / 100;
        return Salario * (1+ reajustePorcentagem);
    }    
    
    public void ImprimirResultado()
    {
        var salarioNovo = CalcularReajuste();
        var reajusteGanho = salarioNovo - Salario;
        Console.Write("Novo salario: {0:f2}\n", salarioNovo);
        Console.Write("Reajuste ganho: {0:f2}\n", reajusteGanho);
        Console.Write("Em percentual: {0} %\n", ObterPorcentagemReajuste());
    }
}