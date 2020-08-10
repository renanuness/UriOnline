using System;

class Uri
{
    static void Main(string[] args)
    {
        
        string ladosRetangulo = Console.ReadLine(); 
        var A = Double.Parse(ladosRetangulo.Split(' ')[0]);
        var B = Double.Parse(ladosRetangulo.Split(' ')[1]);
        var C = Double.Parse(ladosRetangulo.Split(' ')[2]);

        var areaTriangulo = new Triangulo(A,C).CalculaArea();
        var areaCirculo = new Circulo(C).CalculaArea();
        var areaTrapezio = new Trapezio(A, B, C).CalculaArea();
        var areaQuadrado = new Quadrado(B).CalculaArea();
        var areaRetangulo = new Retangulo(A, B).CalculaArea();

        Console.Write("TRIANGULO: {0:f3}\n", areaTriangulo);
        Console.Write("CIRCULO: {0:f3}\n", areaCirculo);
        Console.Write("TRAPEZIO: {0:f3}\n", areaTrapezio);
        Console.Write("QUADRADO: {0:f3}\n", areaQuadrado);
        Console.Write("RETANGULO: {0:f3}\n", areaRetangulo);
    }
}

abstract class FormaGeometrica
{
    public abstract double CalculaArea();
} 

class Triangulo : FormaGeometrica
{
    public double Base {get;set;}
    public double Altura {get;set;}
    public Triangulo(double baseT, double altura)
    {
        Base = baseT;
        Altura = altura;
    }

    public override double CalculaArea()
    {
        return (Base * Altura)/2;
    }
}

class Circulo : FormaGeometrica
{
    const double PI = 3.14159D;
    public double Raio {get;set;}

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalculaArea()
    {
        return Raio * Raio * PI;
    }
}

class Trapezio : FormaGeometrica
{
    public double BaseA {get;set;}
    public double BaseB {get;set;}
    public double Altura {get;set;}

    public Trapezio(double baseA, double baseB, double altura)
    {
        BaseA = baseA;
        BaseB = baseB;
        Altura = altura;
    }

    public override double CalculaArea(){
        return ((BaseA + BaseB) * Altura)/2;
    }
}

class Quadrado : FormaGeometrica
{
    public double Lado {get;set;}

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalculaArea()
    {
        return Lado * Lado;
    }
}

class Retangulo : FormaGeometrica
{
    public double LadoA {get; set;}
    public double LadoB {get;set;}

    public Retangulo(double ladoA, double ladoB)
    {
        LadoA = ladoA;
        LadoB = ladoB;
    }        

    public override double CalculaArea()
    {
        return LadoA * LadoB;
    }
}