using System;
using System.Collections.Generic;
//TODO: errado

class URI
{
    static void Main(string[] args)
    {
        List<int> resultados = new List<int>();
        while(true)
        {
            var entradas = Console.ReadLine();
            if (string.IsNullOrEmpty(entradas))
                break;

            var ladoA = Int32.Parse(entradas.Split(' ')[0]);
            var ladoB = Int32.Parse(entradas.Split(' ')[1]);

            

            var resultado = 0;
            if(EhDivisorComum(ladoA, ladoB))
            {
                resultado = CalcularLadosComMinimoDivisorComum(ladoA, ladoB, Menor(ladoA, ladoB));
                // ImprimirResultado(resultado);
                resultados.Add(resultado);
                continue;
            }

            var maximoDivisorComum = DescobreMaximoDivisorComum(ladoA, ladoB);
            if (maximoDivisorComum != 0)
            {
                resultado = CalcularLadosComMinimoDivisorComum(ladoA, ladoB, maximoDivisorComum);
                // ImprimirResultado(resultado);
                resultados.Add(resultado);

                continue;
            }

            resultado = CalcularDistancia(ladoA, ladoB);

            // ImprimirResultado(resultado);
            resultados.Add(resultado);

        }

        foreach(var resultado in resultados)
            ImprimirResultado(resultado);
    }

    private static void ImprimirResultado(int resultado)
    {
        Console.Write("{0}\n", resultado);
    }

    private static int CalcularLadosComMinimoDivisorComum(int ladoA, int ladoB, int maximoDivisorComum)
    {
        var menorDistanciaA = ladoA / maximoDivisorComum;
        var menorDistanciaB = ladoB / maximoDivisorComum;
        return CalcularDistancia(menorDistanciaA, menorDistanciaB);
    }

    public static int CalcularDistancia(int numeroA, int numeroB)
    {
        return numeroA * 2 + numeroB * 2;
    }

    public static int DescobreMaximoDivisorComum(int numero1, int numero2)
    {
        var menor = Menor(numero1, numero2);
        var maior = Maior(numero2, numero1);
        var metadeDoMenor = menor / 2;
        var i = 2;
        var maiorDivisor= 0;
        while(true)
        {
            var resto = menor % i;
            if(resto == 0)
            {
                var divisor = menor / i;
                if(EhDivisorComum(maior, menor, divisor))
                {
                    maiorDivisor = divisor;
                }
            }
            i++;
            if(i == metadeDoMenor)
                break;
        }
        return 0;
    }

    public static bool EhDivisorComum(int numero1, int numero2, int divisor) => (numero1 % divisor == 0 && numero2 % divisor == 0);

    public static bool EhDivisorComum(int numero1, int numero2)
    {
        var menor = Menor(numero1, numero2);
        var maior = Maior(numero2, numero1);

        if(maior % menor == 0)
            return true;

        return false;
    }
    public static int DescobrirMinimoDivisor(int numero)
    {
        var limite = numero / 2;
        for(int i = 2; i < limite; i++)
        {
            if(numero % i == 0)
                return i;
        }
        return 0;
    }

    public static int Menor(int numero1, int numero2) => numero1 > numero2 ? numero2 : numero1;
    public static int Maior(int numero1, int numero2) => numero2 > numero1 ? numero2 : numero1;
}