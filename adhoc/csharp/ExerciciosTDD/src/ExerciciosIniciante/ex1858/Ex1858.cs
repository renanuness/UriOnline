using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio1858
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1858();
            ex.Executar();
        }
    }

    public class Ex1858
    {
        public void Executar()
        {
            var entradas = LerInteiro();
            var valores = LerMultiplasEntradas(entradas);

            var menorValor = int.MaxValue;
            var posicaoMenor = -1;
            for(int i = 0; i < entradas; i++)
            {
                if(valores[i] < menorValor)
                {
                    menorValor = valores[i];
                    posicaoMenor = i+1;
                }
            }

            Console.Write("{0}\n", posicaoMenor);
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
