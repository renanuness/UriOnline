using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        while(true)
        {
            string entrada = Console.ReadLine();
            if(string.IsNullOrEmpty())
                break;

            int Entradas = Int32.Parse(entrada.Split(' ')[0]);
            string Id = entrada.Split(' ')[1];
            List<Gameplay> gameplays = new List<Gameplay>();

            for(int i = 0; i < Entradas; i++)
            {
                string valroes = Console.ReadLine();
                string id = valroes.Split(' ')[0];
                int jogo = Int32.Parse(valroes.Split(' ')[1]);

                gameplays.Add(new Gameplay(id, jogo));
            }

            int count = gameplays.Where(g => g.Id == Id && g.Jogo == 0).Count();
            Console.Write("{0}\n", count);

        }
    }
}

public class Gameplay
{
    public string Id {get; private set;}
    public int Jogo {get; private set;}

    public Gameplay(string id, int jogo)
    {
        Id = id;
        Jogo = jogo;
    }
}