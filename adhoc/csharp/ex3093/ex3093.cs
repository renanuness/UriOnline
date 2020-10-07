using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        new Partida().ComecarJogo();
    }
}

public class Partida
{
    public List<char> CartasProibidas {get; private set;} 
    
    public void ComecarJogo()
    {
        var partidas = LerNumeroPartidas();
        while(partidas-- >  0)
        {
            ChecarSeTheusinGanhou();
        } 
    }
    
    private int LerNumeroPartidas()
    {
        return Int32.Parse(Console.ReadLine());
    }
    
    private void ChecarSeTheusinGanhou()
    {
        PreencherCartasProibidas();
        var cartasRestantes = LerCartasRestantes();
        foreach(var carta in cartasRestantes)
        {
            if(CartasProibidas.Contains(carta))
                CartasProibidas.Remove(carta);
        }

        ImprimirResultado();
    }
    
    private string LerCartasRestantes()
    {
        return Console.ReadLine();
    }

    private void ImprimirResultado()
    {
        var mensagem = "";
        if(CartasProibidas.Count > 0)
            mensagem = "Ooo raca viu";
        else
            mensagem = "Aaah muleke";
    
        Console.Write("{0}\n", mensagem);
    }
    private void PreencherCartasProibidas()
    {
        CartasProibidas = new List<char>();
        CartasProibidas.Add('Q');
        CartasProibidas.Add('J');
        CartasProibidas.Add('K');
        CartasProibidas.Add('A');
    }
}