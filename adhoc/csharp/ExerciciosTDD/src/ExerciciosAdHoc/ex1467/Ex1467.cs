using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1467
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1467();
            ex.Executar();
        }
    }

    public class Ex1467
    {
        public void Executar()
        {
            var entradas = new int[3];
            while ((entradas = LerMultiplasEntradas(3)) != null)
            {
                var alice = entradas[0];
                var beto = entradas[1];
                var carlos = entradas[2];

                var winner = "";
                if (alice != beto && alice != carlos)
                    winner = "A";
                else if (beto != alice && beto != carlos)
                    winner = "B";
                else if (carlos != alice && carlos != beto)
                    winner = "C";
                else
                    winner = "*";

                Console.Write("{0}\n", winner);
            }
        }

        private string LerLinha()
        {
            return Console.ReadLine();
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
    }
}
