using System;

class URI
{
    static void Main(string[] args)
    {
        string valores = Console.ReadLine();
        int distancia = Int32.Parse(valores.Split(' ')[0]);
        int diametroPS = Int32.Parse(valores.Split(' ')[1]);
        int diametroSP = Int32.Parse(valores.Split(' ')[2]);
    
        var resultado = (double)distancia / (double)(diametroPS + diametroSP);
        
        Console.Write("{0:f2}\n", resultado);
    }
}