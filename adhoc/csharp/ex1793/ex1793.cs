using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        Controle controle = new Controle();
        controle.Comecar();
    }
}

public class Controle
{
    public int TempoAtivada {get; private set;}
    public EscadaRolante EscadaRolante {get; private set;}
    public int NumeroDePessoas {get; private set;}
    public List<int> TemposDeEntrada {get; private set;}
    public Controle()
    {
        EscadaRolante = new EscadaRolante();
        TemposDeEntrada = new List<int>();
        TempoAtivada = 0;
    }

    public void Comecar()
    {
        while(LerNumeroDePessoas())
        {
            LerTemposDeEntrada();
            CalcularTempoAtiva();
            Console.Write("{0}\n",TempoAtivada);
            TempoAtivada = 0;
        }
            
    }
    public bool LerNumeroDePessoas()
    {
        NumeroDePessoas = Int32.Parse(Console.ReadLine());

        if(NumeroDePessoas == 0)
            return false;
        
        return true;
    }

    public void LerTemposDeEntrada()
    {
        TemposDeEntrada.Clear();
        var tempos = Console.ReadLine();
        for(int i = 0; i < NumeroDePessoas; i++)
        {
            var tempo = Int32.Parse(tempos.Split(' ')[i]);
            TemposDeEntrada.Add(tempo);
        }
    }

    public void CalcularTempoAtiva()
    {
        //c   f
        //13  23
        //16  26
        //17  27
        //25  35
        int tempos = TemposDeEntrada.Count;
        for(int i = tempos-1; i >= 0; i--)
        {
            if(i == tempos-1)
                TempoAtivada += 10;
            else
            {
                int intervalo = TemposDeEntrada[i+1] - TemposDeEntrada[i];
                if(intervalo  < 10)
                    TempoAtivada += intervalo;
                else
                    TempoAtivada += 10;
            }
        }
    }
}

public class EscadaRolante
{

}