using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ExerciciosStrings.Exercicio2137
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2137();
            ex.Executar();
        }
    }

    public class Ex2137
    {
        public void Executar()
        {
            List<int> livros = new List<int>();
            string entrada = "";
            while (!string.IsNullOrEmpty(entrada = LerLinha()))
            {
                var numeroDeLivros = LerInteiro(entrada);

                while (numeroDeLivros-- > 0)
                    livros.Add(LerInteiro(LerLinha()));

                livros = livros.OrderBy(x => x).ToList();

                livros.ForEach(x => Console.Write("{0}\n", x.LeadingZeros(4)));

                livros.Clear();
            }


        }

        private int LerInteiro(string entrada)
        {
            return int.Parse(entrada, NumberStyles.Any);
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }

    public static class StringExtensions
    {
        public static string LeadingZeros(this int value, int size)
        {
            var valueString = value.ToString();
            var missing0 = size - valueString.Length;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < missing0; i++)
                sb.Append("0");

            sb.Append(valueString);
            return sb.ToString();
        }
    }
}
