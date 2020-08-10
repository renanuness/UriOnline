using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        List<Item> items = new List<Item>();
        items.Add(new Item(1, "Cachorro Quente", 4.00D));
        items.Add(new Item(2, "X-Salada", 4.50D));
        items.Add(new Item(3, "X-Bacon", 5.00D));
        items.Add(new Item(4, "Torrada Simples", 2.00D));
        items.Add(new Item(5, "Refrigerenta", 1.50D));

        var pedido = Console.ReadLine();

        var itemCodigo     = Int32.Parse(pedido.Split(' ')[0]);
        var itemQuantidade = Int32.Parse(pedido.Split(' ')[1]);

        var itemSelecionado = items.First(i => i.Codigo == itemCodigo);
        itemSelecionado.DefineQuantidade(itemQuantidade);

        var precoPedido = itemSelecionado.CalculaValor();

        Console.Write("Total: R$ {0:f2}\n", precoPedido);
    }
}

public class Item
{
    public int Codigo {get; private set;}
    public string Especificacao {get; private set;}
    public double Preco {get; private set;}
    public int Quantidade {get; private set;}

    public Item(int codigo, string especificacao, double preco)
    {
        Codigo = codigo;
        Especificacao = especificacao;
        Preco = preco;
    } 

    public void DefineQuantidade(int quantidade)
    {
        if(quantidade < 0)
            quantidade *= -1;

        Quantidade = quantidade;
    } 

    public double CalculaValor()
    {
        return Preco * Quantidade;
    }
}