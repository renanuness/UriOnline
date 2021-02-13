using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.Exercicio2157
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2157();
            ex.Executar();
        }
    }

    public class Ex2157
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var entradas = LerMultiplasEntradas(2);

                ImprimirPrimeiraParte(entradas);
                ImprimirSegundaParte(entradas);
                Console.Write("\n");
            }
        }

        private void ImprimirPrimeiraParte(int[] valores)
        {
            for(int i = valores[0]; i <= valores[1]; i++)
            {
                Console.Write("{0}", i);
            }
        }

        private void ImprimirSegundaParte(int[] valores)
        {
            for (int i = valores[1]; i >= valores[0]; i--)
            {
                Console.Write("{0}", i.InverterNumero());
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

    public static class Extensions
    {
        public static string InverterNumero(this int value)
        {
            StringBuilder sb = new StringBuilder();

            var numeroString = value.ToString();
            for(int i = numeroString.Length-1; i >= 0; i--)
            {
                sb.Append(numeroString[i]);
            }

            return sb.ToString();
        }
    }
}
