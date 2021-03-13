using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio2435
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2435();
            ex.Executar();
        }
    }

    public class Ex2435
    {
        public void Executar()
        {
            var entradas1 = LerMultiplasEntradas(3);
            var entradas2 = LerMultiplasEntradas(3);


            var tempo1 = CalcularTempoRestante(entradas1[1], entradas1[2]);
            var tempo2 = CalcularTempoRestante(entradas2[1], entradas2[2]);

            var vencedor = 0;
            if (tempo1 < tempo2)
                vencedor = entradas1[0];
            else
                vencedor = entradas2[0];

            Console.Write("{0}\n", vencedor);
        }

        private decimal CalcularTempoRestante(int distancia, int velocidade)
        {
            decimal velocidadeEmMetrosPorMinuto = (decimal)(velocidade * 1000)/3600;

            return distancia / velocidadeEmMetrosPorMinuto;
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
