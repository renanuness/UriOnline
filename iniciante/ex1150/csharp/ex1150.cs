using System;

class URI
{
    static void Main(string[] args)
    {
        var X = Int32.Parse(Console.ReadLine());
        var Z = 0;
        do{
            Z = Int32.Parse(Console.ReadLine());
        }while(Z < X);

        var  contador = 1;
        var xInicial = X;
        do{
            X += ++xInicial;
            contador++;
        }while(X <= Z);

        Console.Write("{0}\n", contador);
    }
}