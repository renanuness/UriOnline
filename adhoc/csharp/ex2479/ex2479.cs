using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        List<Crianca> criancas = new List<Crianca>();
        var numeroCriancas = Int32.Parse(Console.ReadLine());
        while(numeroCriancas-- > 0)
        {
            var entrada = Console.ReadLine();

            var sinal = entrada.Split(' ')[0];
            var nome = entrada.Split(' ')[1];

            var crianca = new Crianca(sinal, nome);
            criancas.Add(crianca);
        }

        criancas = criancas.OrderBy(c => c.Nome).ToList();

        var mauComportamento = criancas.Count(c => c.FoiComportada == false);
        var bomComportamento = criancas.Count(c => c.FoiComportada == true);
    
        criancas.ForEach( c=> Console.Write("{0}\n", c.Nome));
        Console.Write("Se comportaram: {0} | Nao se comportaram: {1}\n", bomComportamento, mauComportamento);
    }
}

public class Crianca
{
    public bool FoiComportada { get; private set;}
    public string Nome {get; private set;}
    public Crianca(string sinal, string nome)
    {
        Nome = nome;
        FoiComportada = ConverterSinalParaComportamento(sinal);
    }

    public bool ConverterSinalParaComportamento(string sinal) => sinal == "+" ? true : false;
    
}