using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        var portland = new Cidade();
        portland.LerQuantidadeQuadras();
        portland.LerQuadras();
        portland.VerificarQuadras();
    }
}

public class Cidade
{
    public int QuantidadeQuadras {get; private set;}
    public List<Quadra> Quadras {get; private set;}

    public Cidade()
    {
        Quadras = new List<Quadra>();
    }

    public void LerQuantidadeQuadras()
    {
        QuantidadeQuadras = Int32.Parse(Console.ReadLine());
    }

    public void LerQuadras()
    {
        for(int i = 0; i < QuantidadeQuadras; i++)
            Quadras.Add(LerQuadra());
    }
    public Quadra LerQuadra()
    {
        var quadra = new Quadra(); 
        quadra.LerQuadra();
        return quadra;
    }
    public void VerificarQuadras()
    {
        for(int i = 0; i < QuantidadeQuadras; i++)
            Console.Write("{0}\n", Quadras[i].SeguraToString());
    }
}

public class Quadra
{
    public int[] Esquinas {get; private set;}

    public Quadra()
    {
        Esquinas = new int[4];
    }
    public void LerQuadra()
    {
        string quadra1 = Console.ReadLine();
        string quadra2 = Console.ReadLine();
    
        Esquinas[0] = Int32.Parse(quadra1.Split(' ')[0]);
        Esquinas[1] = Int32.Parse(quadra1.Split(' ')[1]);
        Esquinas[2] = Int32.Parse(quadra2.Split(' ')[0]);
        Esquinas[3] = Int32.Parse(quadra2.Split(' ')[1]);
    }

    public bool EhSegura()
    {
        int esquinasSeguras = 0;
        
        for(int i = 0; i < Esquinas.Length; i++)
            if(Esquinas[i] == 1) esquinasSeguras ++;

        return esquinasSeguras >= 2;
    }

    public string SeguraToString()
    {
        string segura = "";
        if(EhSegura())
            segura = "S";
        else
            segura = "U";

        return segura;
    }
}