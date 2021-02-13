using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2807
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2807();
            ex.Executar();
        }
    }

    public class Ex2807
    {
        public void Executar()
        {
            var tamanhoSequencia = LerInteiro();

            int[] sequencia = new int[tamanhoSequencia];

            sequencia[0] = 1;
            if (tamanhoSequencia == 1)
            {
                ImprimirSequencia(sequencia);
                return;
            }

            sequencia[1] = 1;
            
            for (int i = 2; i < tamanhoSequencia; i++)
            {
                sequencia[i] = sequencia[i - 1] + sequencia[i - 2];
            }

            ImprimirSequencia(sequencia);
        }

        private void ImprimirSequencia(int[] sequencia)
        {
            for (int i = sequencia.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", sequencia[i]);
                if (i == 0)
                    Console.Write("\n");
                else
                    Console.Write(" ");
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

    }
}
