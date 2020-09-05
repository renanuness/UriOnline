using System;

class URI
{
    static void Main(string[] args)
    {
        Xp xp = new Xp();

        xp.Executar();
    }
}

public class Xp
{
    public int M {get; private set;}
    public int X {get; private set;}
    
    public void Executar()
    {
        while(LerValores())
        {
            Imprimir();
        }
    }
    public bool LerValores()
    {
        string entrada = Console.ReadLine();
        M = Int32.Parse(entrada.Split(' ')[0]);
        X = Int32.Parse(entrada.Split(' ')[1]);
        return (M!=0 && X!=0);
    }

    public void Imprimir()
    {
        Console.Write("{0}\n", M*X);
    } 
}