using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosIniciante.Exercicio2534
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2534();
            ex.Executar();
        }
    }

    public class Ex2534
    {
        public void Executar()
        {
            int[] entradas;
            while ((entradas = LerMultiplasEntradas(2)) != null)
            {
                var numeroHabitantes = entradas[0];
                var numeroConsultas = entradas[1];

                List<int> notas = new List<int>();
                for (int i = 0; i < numeroHabitantes; i++)
                {
                    notas.Add(LerInteiro());
                }

                notas = notas.OrderByDescending(x => x).ToList(); ;

                for (int i = 0; i < numeroConsultas; i++)
                {
                    var posicao = LerInteiro();
                    Console.Write("{0}\n", notas[posicao-1]);
                }
            }
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
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
