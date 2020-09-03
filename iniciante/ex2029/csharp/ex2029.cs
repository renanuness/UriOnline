using System;

class URI
{
    static void Main(string[] args)
    {
        Cilindro cilindro = new Cilindro();

        cilindro.IniciarPrograma();
    }
}

public class Cilindro
{
    public double Volume {get; private set;}
    public double Diametro{get;private set;}
    public double Area{get; private set;}
    public double Altura{get;private set;}
    
    public void IniciarPrograma()
    {
        while(LerValores())
        {
            CalcularAltura();
            CalcularAreaBase();
            Imprimir();
        }
    }
    private bool LerValores()
    {
        string valor = Console.ReadLine();
        if(string.IsNullOrEmpty(valor))
            return false;

        Volume = double.Parse(valor);

        valor = Console.ReadLine();
        if(string.IsNullOrEmpty(valor))
            return false;
        
        Diametro = double.Parse(valor);
        return true; 
    }

    private void CalcularAltura()
    {
        var raio = Diametro * 0.5;
        Altura = Volume/(3.14*raio*raio);
    }

    private void CalcularAreaBase()
    {
        Area = Volume / Altura;
    }

    private void Imprimir()
    {
        Console.Write("ALTURA = {0:f2}\n", Altura);
        Console.Write("AREA = {0:f2}\n", Area);
    }
}