using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio2472
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2472();
            ex.Executar();
        }
    }

    public class Ex2472
    {
        public void Executar()
        {
            var entradas = LerMultiplasEntradas(2);

            var tamanhoTubo = entradas[0];
            var numeroDeTapetes = entradas[1];

            var maiorTapete = (tamanhoTubo - numeroDeTapetes) + 1;
            var espacoRestante = tamanhoTubo - maiorTapete;
            var tapetesRestantes = numeroDeTapetes - 1;

            var areaTotal = (long)maiorTapete * maiorTapete + tapetesRestantes;

            Console.Write("{0}\n", areaTotal);

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
