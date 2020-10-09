using System;

class URI
{
    static void Main(string[] args)
    {
        while(true)
        {
            var numero = LerInteiro();
            if(numero == 0)
                break;

            int[] digitos = SepararDigitos(numero);
            var soma = 0;
            var index = 0;

            for(int i = digitos.Length; i > 0 ; i--)
            {
                soma += digitos[index++] * i.Fatorial();
            }
            Console.Write("{0}\n", soma);
        }
    }

    public static int LerInteiro()
    {
        return Int32.Parse(Console.ReadLine());
    }

    public static int[] SepararDigitos(int digitos)
    {
        string numerosString = digitos.ToString();
        int[] numeros = new int[numerosString.Length];

        int index = 0;
        foreach(var digito in numerosString)
        {
            numeros[index++] = Int32.Parse(digito.ToString());
        }
        return numeros;
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