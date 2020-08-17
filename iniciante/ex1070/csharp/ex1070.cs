using System;

class URI
{
    static void Main(string[] args)
    {
        var calculadoraMedia = new CalculadoraMedia();
        calculadoraMedia.LeQuantidadeDeCasos();
        calculadoraMedia.ExecutarRepeticao();
    }
}

public class CalculadoraMedia
{
    private const double PESO_UM = 2;
    private const double PESO_DOIS = 3;
    private const double PESO_TRES = 5;
    public int CasosDeTeste {get; private set;}
    public double Media{get; private set;}
    public string Notas{get; private set;}

    public CalculadoraMedia()
    {
        Media = 0;
    } 

    public void ExecutarRepeticao()
    {
        for(int i = 0; i < CasosDeTeste; i++)
            ExecutarProcesso();
    }

    private void ExecutarProcesso()
    {
        LerNotas();
        CalcularMedia();
        ImprimirMedia();
    }

    public void LeQuantidadeDeCasos()
    {
        CasosDeTeste = Int32.Parse(Console.ReadLine());
    }

    public void LerNotas()
    {
        Notas = Console.ReadLine();
    }

    public void  CalcularMedia()
    {
        var somaDosPesos = SomarPesos();
        var notaUm = double.Parse(Notas.Split(' ')[0]);
        var notaDois = double.Parse(Notas.Split(' ')[1]);
        var notaTres = double.Parse(Notas.Split(' ')[2]);
        
        Media = (notaUm *(PESO_UM/somaDosPesos)) + 
                    (notaDois *(PESO_DOIS/somaDosPesos)) +
                    (notaTres *(PESO_TRES/somaDosPesos));
    }

    public void ImprimirMedia()
    {
        Console.Write("{0:f1}\n", Media);
    }

    private double SomarPesos() => PESO_UM + PESO_DOIS + PESO_TRES;
}