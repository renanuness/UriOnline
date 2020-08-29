using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        List<double> lados = Leitor.LerValores();

        FormaGeometrica forma = FormaFactory.CriarForma(lados);

        forma.ImprimirValor();
    }
}
public static class Leitor
{
    public static List<double> LerValores()
    {
        List<double> lados = new List<double>();

        string valores = Console.ReadLine();
        double ladoA = double.Parse(valores.Split(' ')[0]);
        double ladoB = double.Parse(valores.Split(' ')[1]);
        double ladoC = double.Parse(valores.Split(' ')[2]);
        lados.Add(ladoA);        
        lados.Add(ladoB);        
        lados.Add(ladoC);

        return lados;        
    }
}
public static class FormaFactory
{
    public static FormaGeometrica CriarForma(List<double> lados)
    {
        if(EhTriangulo(lados))
            return CriarTriangulo(lados);

        return CriarTrapezio(lados);
    }

    private static Triangulo CriarTriangulo(List<double> lados)
    {
        return new Triangulo(lados);
    }

    private static Trapezio CriarTrapezio(List<double> lados)
    {
        return new Trapezio(lados);
    }
    
    private static bool EhTriangulo(List<double> lados)
    {
        List<double> localLados = new List<double>(lados);
        localLados.Sort();

        if(localLados[0] + localLados[1] <= localLados[2]) return false;

        return true;
    }     
}

public abstract class FormaGeometrica
{
    public abstract double Calcular();
    public abstract void ImprimirValor();
}

public class Triangulo : FormaGeometrica
{
    List<double> _lados = new List<double>();

    public Triangulo( List<double> lados)
    {
        _lados = lados;
    } 

    public override double Calcular()
    {
        return _lados.Sum();
    }

    public override void ImprimirValor()
    {
        Console.Write("Perimetro = {0:f1}\n", Calcular());
    }
} 

public class Trapezio : FormaGeometrica
{
    List<double> _lados = new List<double>();

    public Trapezio( List<double> lados)
    {
        _lados = lados;
    }

    public override double Calcular(){
        return ((_lados[0] + _lados[1])*_lados[2])/2;
    }

    public override void ImprimirValor()
    {
        Console.Write("Area = {0:f1}\n", Calcular());
        
    }
} 