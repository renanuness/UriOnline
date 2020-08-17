using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {

    }
}

public class Gameplay
{
    public List<Dictionary<string,int>>  Gameplays {get; private set;}
    public string Id {get; private set;}
    public int Entradas {get; private set;}

    public void LerValores()
    {
        string entrada = Console.ReadLine();
        Entradas = Int32.Parse(entrada.Split(' ')[1]);
        Id = entrada.Split(' ')[1];
    }

    public void EncontrarGameplayCs()
    {
        Gameplays

    }
}