using System;

class URI
{
    static void Main(string[] args)
    {
        JogoDoMaior jogoDoMaior = new JogoDoMaior();

        jogoDoMaior.LerNumeroDeRodadas();
        jogoDoMaior.ImprimirResultados();
    }
}

public class JogoDoMaior
{
    public int PontosA {get; private set;}
    public int PontosB {get; private set;}
    public int Rodadas {get; private set;}

    public void LerNumeroDeRodadas()
    {
        while(true)
        {
            Rodadas = Int32.Parse(Console.ReadLine());
            if(Rodadas == 0)
                break;

            LerRodadas();    
        }
    }

    public void LerRodadas()
    {
        while(Rodadas-- > 0)
        {
            ComputarPartida();
        }
    }
    public void ComputarPartida()
    {
        var resultado = Console.ReadLine();
        var placarA = Int32.Parse(resultado.Split(' ')[0]);
        var placarB = Int32.Parse(resultado.Split(' ')[1]);

        if( placarA > placarB)
            PontosA++;
        if(placarB > placarA)
            PontosB++;
    }

    public void ImprimirResultados()
    {
        Console.Write("{0} {1}\n", PontosA, PontosB);
    }
}