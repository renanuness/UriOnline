using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        string valores = Console.ReadLine();

        double ladoA =  double.Parse(valores.Split(' ')[0]);
        double ladoB =  double.Parse(valores.Split(' ')[1]);
        double ladoC =  double.Parse(valores.Split(' ')[2]);

        List<double> lados = new List<double>();
        lados.Add(ladoA);
        lados.Add(ladoB);
        lados.Add(ladoC);
        
        lados.Sort((a,b) => b.CompareTo(a));

        ladoA = lados[0];
        ladoB = lados[1];
        ladoC = lados[2];
        
        if(!Triagulos.EhTriangulo(ladoA, ladoB, ladoC))
        {
            Console.Write("NAO FORMA TRIANGULO\n"); 
            return;
        }

        if(Triagulos.EhTrianguloRetangulo(ladoA, ladoB, ladoC)) Console.Write("TRIANGULO RETANGULO\n");
        else if(Triagulos.EhTrianguloObtusangulo(ladoA, ladoB, ladoC)) Console.Write("TRIANGULO OBTUSANGULO\n");
        else if(Triagulos.EhTrianguloAcutangulo(ladoA, ladoB, ladoC)) Console.Write("TRIANGULO ACUTANGULO\n");
        
        if(Triagulos.EhTrianguloEquilatero(ladoA, ladoB, ladoC)) Console.Write("TRIANGULO EQUILATERO\n");
        else if(Triagulos.EhTrianguloIsosceles(ladoA, ladoB, ladoC)) Console.Write("TRIANGULO ISOSCELES\n");
    }
 
}

public static class Triagulos
{
    public static bool EhTriangulo(double ladoA, double ladoB, double ladoC)
    {
        if(ladoA >= ladoB + ladoC) return false;

        return true;
    }

       public static bool EhTrianguloRetangulo(double ladoA, double ladoB, double ladoC)
    {
        ladoA = Math.Pow(ladoA,2);
        ladoB = Math.Pow(ladoB,2);
        ladoC = Math.Pow(ladoC,2);

        if(ladoA == ladoB + ladoC) return true;

        return false;
    }

    public static bool EhTrianguloObtusangulo(double ladoA, double ladoB, double ladoC)
    {
        ladoA = Math.Pow(ladoA,2);
        ladoB = Math.Pow(ladoB,2);
        ladoC = Math.Pow(ladoC,2);

        if(ladoA > ladoB + ladoC) return true;

        return false;
    }

    public static bool EhTrianguloAcutangulo(double ladoA, double ladoB, double ladoC)
    {
        ladoA = Math.Pow(ladoA,2);
        ladoB = Math.Pow(ladoB,2);
        ladoC = Math.Pow(ladoC,2);

        if(ladoA < ladoB + ladoC) return true;

        return false;
    }

    public static bool EhTrianguloEquilatero(double ladoA, double ladoB, double ladoC)
    {
        if(ladoA == ladoB && ladoB == ladoC) return true;

        return false;
    }

    public static bool EhTrianguloIsosceles(double ladoA, double ladoB, double ladoC)
    {
        if(ladoA == ladoB && ladoB != ladoC) return true;
        if(ladoA == ladoC && ladoC != ladoB) return true;
        if(ladoB == ladoC && ladoC != ladoA) return true;

        return false;
    }
}