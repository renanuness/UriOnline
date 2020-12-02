using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        var campeonato = new Campeonato();

        campeonato.JogarCampeonato();
    }
}

public class Campeonato
{
    public List<Equipe> Equipes {get; private set;}
    public List<Partida> FaseAtual {get; private set;}

    public Campeonato()
    {
        FaseAtual = new List<Partida>();
        Equipes = new List<Equipe>();

        Equipes.Add(new Equipe("A"));
        Equipes.Add(new Equipe("B"));
        Equipes.Add(new Equipe("C"));
        Equipes.Add(new Equipe("D"));
        Equipes.Add(new Equipe("E"));
        Equipes.Add(new Equipe("F"));
        Equipes.Add(new Equipe("G"));
        Equipes.Add(new Equipe("H"));
        Equipes.Add(new Equipe("I"));
        Equipes.Add(new Equipe("J"));
        Equipes.Add(new Equipe("K"));
        Equipes.Add(new Equipe("L"));
        Equipes.Add(new Equipe("M"));
        Equipes.Add(new Equipe("N"));
        Equipes.Add(new Equipe("O"));
        Equipes.Add(new Equipe("P"));
    }

    public Placar LerResultado()
    {
        var placar = new Placar();

        var entrada = Console.ReadLine();

        var mandante = entrada.Split(' ')[0];
        var visitante = entrada.Split(' ')[1];

        var golsMandante = Int32.Parse(mandante);
        var golsVisitante = Int32.Parse(visitante);
    
        placar.DefinirPlacar(golsMandante, golsVisitante);

        return placar;
    }

    public void JogarCampeonato()
    {
        do{
            CriarPartidas();
            JogarPartidas();
            AvancarFase();
        }while(Equipes.Count > 1);

        Console.Write("{0}\n", Equipes[0].Nome);
    }

    public void CriarPartidas()
    {
        for (int i =0; i < Equipes.Count; i+=2)
        {
           var partida = new Partida(Equipes[i],Equipes[i+1]); 
           FaseAtual.Add(partida);
        }
    }

    public void JogarPartidas()
    {
        foreach (var partida in FaseAtual)
        {
            partida.DefinirPlacar(LerResultado());
        }
    }

    public void AvancarFase()
    {
        var equipesClassificadas = new List<Equipe>();

        foreach (var partida in FaseAtual)
        {
            equipesClassificadas.Add(partida.ObterVencedor());
        }
        
        Equipes.Clear();
        FaseAtual.Clear();
        Equipes.AddRange(equipesClassificadas);
    } 
}

public class Partida
{
    public Equipe Mandante {get; private set;}
    public Equipe Visitante {get; private set;}
    public Placar Placar {get; private set;}

    public Partida(Equipe m, Equipe v)
    {
        Mandante = m;
        Visitante = v;
    }

    public void DefinirPlacar(Placar p)
    {
        Placar = p;
    }

    public Equipe ObterVencedor()
    {
        if(Placar.Mandante > Placar.Visitante)
            return Mandante;
        if(Placar.Mandante < Placar.Visitante)
            return Visitante;
        
        return null;
    }
}

public class Equipe
{
    public string Nome {get; private set;}

    public Equipe(string nome)
    {
        Nome = nome;
    }
}

public class Placar
{
    public int Mandante {get; private set;}
    public int Visitante {get; private set;}

    public void DefinirPlacar(int mandante, int visitante)
    {
        Mandante = mandante;
        Visitante = visitante;
    }
}