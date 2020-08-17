using System;

class URI
{
    static void Main(string[] args)
    {
        var grenal = new Grenal();

        grenal.ComputarResultado();
    }
}

public class Grenal
{
    private const string INTER = "Inter";
    private const string GREMIO = "Gremio";
    public int VitoriasInter {get; private set;}
    public int VitoriasGremio {get; private set;}
    public int Empates {get; private set;}
    
    public void ComputarResultado()
    {
        string resultado = Console.ReadLine();
        var golsInter = Int32.Parse(resultado.Split(' ')[0]);
        var golsGremio = Int32.Parse(resultado.Split(' ')[1]);
    
        if(golsInter > golsGremio) VitoriasInter++;
        if(golsInter < golsGremio) VitoriasGremio++;
        if(golsInter == golsGremio) Empates++;

        MostrarMenu();
    }
    
    public void MostrarMenu()
    {
        Console.Write("Novo grenal (1-sim 2-nao)\n");
        var opcao = Int32.Parse(Console.ReadLine());
        if(opcao == 1)
            ComputarResultado();
        if(opcao == 2)
            MostrarResultados();
    }

    private void MostrarResultados()
    {
        MostrarTotalDeJogos();
        MostrarVitoriasInter();
        MostrarVitoriasGremio();
        MostrarEmpates();
        MostrarVencedor();
    }

    private void MostrarTotalDeJogos()
    {
        var totalJogos =  VitoriasInter + VitoriasGremio + Empates;
        Console.Write("{0} grenais\n", totalJogos);
    }

    private void MostrarVencedor()
    {
        if(VitoriasInter > VitoriasGremio)
            Console.Write("Inter venceu mais\n");
            
        if(VitoriasGremio > VitoriasInter)
            Console.Write("Gremio venceu mais\n");
        if(VitoriasGremio == VitoriasInter)
            Console.Write("Nao houve vencedor\n");
    }

    private void MostrarVitoriasInter() => Console.Write("Inter:{0}\n", VitoriasInter);
    
    private void MostrarVitoriasGremio() => Console.Write("Gremio:{0}\n", VitoriasGremio);
    
    private void MostrarEmpates() => Console.Write("Empates:{0}\n", Empates);
}