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
    public int[,] Esquinas {get; private set;}

    public void LerQuantidadeQuadras()
    {
        QuantidadeQuadras = Int32.Parse(Console.ReadLine());
        int numeroEsquinas =  NumeroEsquinas();
        Esquinas = new int[numeroEsquinas, numeroEsquinas];
    }

    public void LerQuadras()
    {
        int numeroEsquinas =  NumeroEsquinas();

        for(int i = 0; i < numeroEsquinas; i++)            
            LerEsquina(linha: i);
    }
    
    private void LerEsquina(int linha)
    {

        string esquinas = Console.ReadLine();
        for(int j = 0; j < NumeroEsquinas(); j++)
        {
            Esquinas[linha,j] = Int32.Parse(esquinas.Split(' ')[j]);
        }
    }

    public void VerificarQuadras()
    {
        int numeroEsquinas =  NumeroEsquinas();
        for(int i = 0; i < numeroEsquinas - 1; i++){
            for(int j = 0; j < numeroEsquinas - 1; j++)
            {
                Quadra quadra = new Quadra(Esquinas[i,j], Esquinas[i+1,j], Esquinas[i,j+1], Esquinas[i+1,j+1]);
                Console.Write(quadra.SeguraToString());
            }
                Console.Write("\n");
        }
    }

    public int NumeroEsquinas() => QuantidadeQuadras + 1;
}

public class Quadra
{
    public int[] Esquinas {get; private set;}

    public Quadra(int e1, int e2, int e3, int e4)
    {
        Esquinas = new int[4];
        Esquinas[0] = e1;
        Esquinas[1] = e2;
        Esquinas[2] = e3;
        Esquinas[3] = e4;
    }

    private bool EhSegura()
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