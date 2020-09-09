using System;

class URI
{
    static void Main(string[] args)
    {
        var controlador = new Controlador();
        
        while(controlador.EstaAberto())
        {
            controlador.LerEntrada();
        }
        controlador.ImprimirSituacao();
    }
}

public class Controlador
{
    private const string SALIDA = "SALIDA";
    private const string VUELTA = "VUELTA";
    private const string ABEND = "ABEND";

    private int QuantidadeCarros {get;set;}
    private int QuantidadeTuristas {get;set;}
    private bool ParqueFechado {get;set;}

    public Controlador()
    {
        ParqueFechado = false;
    }

    public bool EstaAberto()
    {
        return !ParqueFechado;
    }
    public void LerEntrada()
    {
        string entrada = Console.ReadLine();
        if(entrada.Split(' ')[0] == SALIDA)
        {
            ComputaEntrada(Int32.Parse(entrada.Split(' ')[1]));
            return;
        }

        if(entrada.Split(' ')[0] == VUELTA)
        {
            ComputaSaida(Int32.Parse(entrada.Split(' ')[1]));
            return;
        }
        if(entrada.Split(' ')[0] == ABEND)
            ParqueFechado = true;
    }

    public void ComputaEntrada(int numeroPessoas)
    {
        QuantidadeCarros++;
        QuantidadeTuristas += numeroPessoas;
    }

    public void ComputaSaida(int numeroPessoas)
    {
        QuantidadeCarros--;
        QuantidadeTuristas -= numeroPessoas;
    }

    public void ImprimirSituacao()
    {
        Console.Write("{0}\n", QuantidadeTuristas);
        Console.Write("{0}\n", QuantidadeCarros);
    }
}