using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        var primeiraLinha = Console.ReadLine();
        var segundaLinha = Console.ReadLine();
    
        var montanhas = Int32.Parse(primeiraLinha.Split(' ')[0]);
        var variacaoMaxima = Int32.Parse(primeiraLinha.Split(' ')[1]);
        List<int> alturas = new List<int>();

        for(int i = 0; i < montanhas; i++)
        {
            var altura = Int32.Parse(segundaLinha.Split(' ')[i]);
            alturas.Add(altura);
        }

        var maiorSequencia = 0;
        var anterior = -1;
        var sequenciaAtual = 1;

        for(int i = 0; i < alturas.Count; i++)
        {
            if(anterior != -1)
            {
                var diferenca = alturas[i] - anterior;
                if(diferenca > variacaoMaxima)
                {
                    sequenciaAtual = 1;
                }
                else
                {
                    sequenciaAtual++;
                    if(sequenciaAtual > maiorSequencia)
                        maiorSequencia = sequenciaAtual;
                }
            }
            anterior = alturas[i];
        }

        if(maiorSequencia == 0)
            maiorSequencia = 1;

        Console.Write("{0}\n", maiorSequencia);
    }
}