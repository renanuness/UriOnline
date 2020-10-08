using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
         var valor = Int32.Parse(Console.ReadLine());
        
        var fatoriaisContador = 0;
        var soma = 0;
        for(int i = 12; i > 0; i--)
        {
            while(soma + i.Fatorial() <= valor)
            {
                soma += i.Fatorial();
                fatoriaisContador++;
            }
        }
        Console.Write("{0}\n", fatoriaisContador);
    }
}

public static class Extension
{
    public static int Fatorial(this int valor) 
    {
        int fatorial = valor;

        for(int i = valor-1; i > 1; i--)
        {
            fatorial *= i ;
        }
        return fatorial;
    }
}