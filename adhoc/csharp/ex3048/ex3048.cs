using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        var numerosNaSquencia = Int32.Parse(Console.ReadLine());

        var contagem = 0;
        var numeroAtual = 0;
        while(numerosNaSquencia-- > 0)
        {
            var numero = Int32.Parse(Console.ReadLine());

            if(numero != numeroAtual)
            {
                contagem++;
                numeroAtual = numero;
            }
        }

        Console.Write("{0}\n", contagem);
    }
}