using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        var pedraPapel = new PedraPapel();
        pedraPapel.LerNumeroPartidas();
        pedraPapel.ComputarPartidas();
        pedraPapel.MostrarResultados();
    }
}

public class PedraPapel
{
    public int NumeroPartidas {get; private set;}
    public List<Duelo> Duelos {get; private set;}

    public PedraPapel()
    {
        Duelos = new List<Duelo>();
    }

    public void ComputarPartidas()
    {
        for(int i = 0; i < NumeroPartidas; i++)
            LerAtaques();
    }

    public void MostrarResultados()
    {
        for(int i = 0; i < NumeroPartidas; i++)
            Console.Write("{0}\n", Duelos[i].DecidirVencedor());
    }
    public void LerNumeroPartidas()
    {
        NumeroPartidas = Int32.Parse(Console.ReadLine());
    }
    
    public void LerAtaques()
    {
        var jogador1 = new Jogador(Console.ReadLine());
        var jogador2 = new Jogador(Console.ReadLine());
        Duelos.Add(new Duelo(jogador1, jogador2));
    }
}

public class Jogador
{
    public string Arma {get; private set;}

    public Jogador(string arma)
    {
        Arma = arma;
    }
}

public class Duelo
{
    public Jogador Jogador1 {get; private set;}
    public Jogador Jogador2 {get; private set;}
    public string Resultado {get; private set;}

    public Duelo(Jogador j1, Jogador j2)
    {
        Jogador1 = j1;
        Jogador2 = j2;
    }

    public string DecidirVencedor()
    {
        Resultado = Jogador1.Arma.Decisao(Jogador2.Arma);
        return Resultado;
    }
}
public static class Juiz
{
    const string ATAQUE = "ataque";
    const string PEDRA = "pedra";
    const string PAPEL = "papel";

    public static string Decisao(this string arma, string contra)
    {
        if(arma == ATAQUE)
        {
            if(contra == ATAQUE)
                return "Aniquilacao mutua";
            if(contra == PEDRA)
                return "Jogador 1 venceu";
            if(contra == PAPEL)
                return "Jogador 1 venceu";
        }

        if(arma == PEDRA)
        {
            if(contra == ATAQUE)
                return "Jogador 2 venceu";
            if(contra == PEDRA)
                return "Sem ganhador";
            if(contra == PAPEL)
                return "Jogador 1 venceu";
        }

        if(arma == PAPEL)
        {
            if(contra == ATAQUE)
                return "Jogador 2 venceu";
            if(contra == PEDRA)
                return "Jogador 2 venceu";
            if(contra == PAPEL)
                return "Ambos venceram";
        }

        return "CASO NAO COMPUTADO";
    }
}