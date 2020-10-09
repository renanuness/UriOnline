using System;

class URI
{
    static void Main(string[] args)
    {
        var casosDeTeste = Int32.Parse(Console.ReadLine());
        while(casosDeTeste-- > 0)
        {
            var entrada = Console.ReadLine();

            var exclamacoes = ContarFatorial(entrada);
            var entradaSoNumeros = entrada.Replace("!", "");
            var numero = Int32.Parse(entradaSoNumeros);

            var fatorial = numero.Fatorial(exclamacoes);

            Console.Write("{0}\n", fatorial);
        }
    }

    public static int ContarFatorial(string entrada)
    {
        var exclamacoes = 0;
        foreach(var digito in entrada)
        {
            if(digito == '!')
                exclamacoes++;
        }
        return exclamacoes;
    }
}

public static class Extension
{
    public static long Fatorial(this int valor, int step) 
    {
        long fatorial = valor;

        for(int i = valor-step; i > 1; i -= step)
        {
            fatorial *= i ;
        }
        return fatorial;
    }
}