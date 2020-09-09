using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        List<int> entradas = new List<int>();

        while(true)
        {
            int entrada = Int32.Parse(Console.ReadLine());
            if(entrada == 0) break;
            entradas.Add(entrada);
        }

        foreach(var entrada in entradas)
        {
            int[,] matriz = new int[entrada,entrada];
            int maiorNumeroDigitos = 0;
            if(entrada > 1) maiorNumeroDigitos = Math.Pow(2,(entrada + entrada -2 )).ToString().Length;

            for(int i = 0; i < entrada; i++)
            {
                for(int j = 0; j < entrada; j++)
                {
                    Console.Write(String.Format("{0,"+ maiorNumeroDigitos +"}", Math.Pow(2 ,(i+j))));
                    if(j != entrada-1) Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}