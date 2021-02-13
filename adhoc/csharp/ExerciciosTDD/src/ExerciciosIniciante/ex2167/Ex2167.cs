using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2167
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2167();
            ex.Executar();
        }
    }

    public class Ex2167
    {
        public void Executar()
        {
            var casos = LerInteiro();

            var numeros = LerMultiplasEntradas(casos);

            var anterior = 0;
            for(int i = 0; i < casos; i++)
            {
                if(i == 0)
                {
                    anterior = numeros[i];
                    continue;
                }

                if(numeros[i] < anterior)
                {
                    Console.Write("{0}\n", i+1);
                    break;
                }
                anterior = numeros[i];
            
                if(i == casos-1)
                    Console.Write("0\n");
            }
        }

        private int[] LerMultiplasEntradas(int entradas)
        {
            var entrada = LerLinha();

            if (string.IsNullOrEmpty(entrada))
                return null;

            int[] valores = new int[entradas];
            var entradaArray = entrada.Split(' ');
            for (int i = 0; i < entradas; i++)
            {
                valores[i] = int.Parse(entradaArray[i]);
            }

            return valores;
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }
}
