using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.ex1871
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1871();
            ex.Executar();
        }
    }

    public class Ex1871
    {
        public void Executar()
        {
            while (true)
            {
                var entradas = LerMultiplasEntradas(2);

                if (entradas[0] + entradas[1] == 0)
                    break;

                var resultado = entradas[0] + entradas[1];

                var saida = resultado.ToString().Replace("0", "");

                Console.Write("{0}\n", saida);


            }
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        private int[] LerMultiplasEntradas(int entradas)
        {
            var entrada = LerLinha();

            int[] valores = new int[entradas];
            var entradaArray = entrada.Split(' ');
            for (int i = 0; i < entradas; i++)
            {
                valores[i] = int.Parse(entradaArray[i]);
            }

            return valores;
        }
    }
}
