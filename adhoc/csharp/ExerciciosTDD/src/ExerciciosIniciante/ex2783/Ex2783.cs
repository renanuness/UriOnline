using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosIniciante.Exercicio2783
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2783();
            ex.Executar();
        }
    }

    public class Ex2783
    {
        public void Executar()
        {
            var entradas = LerMultiplasEntradas(3);

            var numeroDeFigurinhas = entradas[0];
            var numeroDeFigurinhasCarimbadas = entradas[1];
            var numeroDeFigurinhasCompradas = entradas[2];

            var figurinhasCarimbadas = LerMultiplasEntradas(numeroDeFigurinhasCarimbadas);
            var figurinhasCompradas = LerMultiplasEntradas(numeroDeFigurinhasCompradas);

            var carimbadasFaltantes = numeroDeFigurinhasCarimbadas;
            for(int i = 0; i < figurinhasCarimbadas.Length; i++)
            {
                var figurinha = figurinhasCarimbadas[i];

                if (figurinhasCompradas.Any(x => x == figurinha))
                    carimbadasFaltantes--;
            }

            Console.Write("{0}\n", carimbadasFaltantes);
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
