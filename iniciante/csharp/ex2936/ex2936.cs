using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        var quantidade = 0;

        List<int> porcoes = new List<int>();
        porcoes.Add(300);
        porcoes.Add(1500);
        porcoes.Add(600);
        porcoes.Add(1000);
        porcoes.Add(150);

        var contador = 0;
        while(contador < porcoes.Count)
        {
            var entrada = Int32.Parse(Console.ReadLine());
            quantidade += entrada * porcoes[contador];

            contador++;
        }

        quantidade += 225;

        Console.Write("{0}\n", quantidade);
    }
}