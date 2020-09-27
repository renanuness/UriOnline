using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        while(true){
            List<Contato> contatos = new List<Contato>();
            var entradas = Int32.Parse(Console.ReadLine());
            if(entradas == 0)
                break;
            while(entradas-- > 0)
            {
                var entrada = Console.ReadLine();
                var nome = entrada.Split(' ')[0];
                var anoDeRecebimento = Int32.Parse(entrada.Split(' ')[1]);
                var anosParaChegarNaTerra = Int32.Parse(entrada.Split(' ')[2]);

                contatos.Add(new Contato(nome, anosParaChegarNaTerra, anoDeRecebimento));
            }

            contatos.Sort();
    
            Console.Write("{0}\n", contatos[0].Nome);
        }
    }
}

public class Contato : IComparable
{
    public int AnosParaChegarNaTerra {get; private set;}
    public string Nome {get;private set;}
    public int AnoRecebimento{get; private set;}
    public int AnoDeEnvio {get;set;}

    public Contato(string nome, int anosParaChegarNaTerra, int anoRecebimento)
    {
        AnosParaChegarNaTerra = anosParaChegarNaTerra;
        Nome = nome;
        AnoRecebimento = anoRecebimento;
        AnoDeEnvio = AnoRecebimento - AnosParaChegarNaTerra;
    }

    public int CompareTo(object other)
    {
        if(other == null) return 1;

        Contato otherContato = other as Contato;
        
        if(otherContato != null)
            return this.AnoDeEnvio.CompareTo(otherContato.AnoDeEnvio);
        else
            throw new ArgumentException("Objeto não é contato");
    }
}