using System;

class URI
{
    static void Main(string[] args)
    {
        var M = -1;
        var X = -1;

        do{


            
        } while(M!=0 & X!=0);
    }
}

public class Xp
{
    public int M {get; private set;}
    public int X {get; private set;}
    
    public void LerValores()
    {
        string entrada = Console.ReadLine();
        M = Int32.Parse(entrada.Split(' ')[0]);
        X = Int32.Parse(entrada.Split(' ')[1]);
    }

    public override void ToString()
    {
        Console.Write("{0}\n", M*X);
    } 
}