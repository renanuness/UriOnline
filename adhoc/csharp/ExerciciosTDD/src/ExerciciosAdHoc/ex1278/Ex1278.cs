using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExerciciosAdHoc.ex1278
{
    public static class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1278();
            List<List<string>> respostas = new List<List<string>>();

            var casosDeTeste = ex.LerCasosDeTeste();
            do
            {
                var texto = ex.LerTexto(casosDeTeste);
                texto = ex.RemoverEspacos(texto);
                var maiorLinha = ex.CalcularMaiorLinha(texto);
                texto = ex.AlinharDireita(texto, maiorLinha);

                respostas.Add(texto);

                casosDeTeste = ex.LerCasosDeTeste();
            } while (casosDeTeste != 0);


            for (int i = 0; i < respostas.Count; i++)
            {
                respostas[i].ForEach(t => Console.Write("{0}\n", t));
                if (i < respostas.Count - 1)
                    Console.Write("\n");
            }
        }

        public static string RemoverEspacos(this string texto)
        {
            texto = texto.Trim();

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            texto = regex.Replace(texto, " ");
            return texto;
        }

    }

    public class Ex1278
    {
        private string LerLinha()
        {
            return Console.ReadLine();
        }
        public int LerCasosDeTeste()
        {
            return int.Parse(LerLinha());
        }

        public List<string> AlinharDireita(List<string> texto, int offSet)
        {
            for (int i = 0; i < texto.Count; i++)
                texto[i] = texto[i].PadLeft(offSet);

            return texto;
        }

        public List<string> RemoverEspacos(List<string> texto)
        {
            for (int i = 0; i < texto.Count; i++)
                texto[i] = texto[i].RemoverEspacos();

            return texto;
        }

        public List<string> LerTexto(int linhas)
        {
            List<string> texto = new List<string>();
            for (int i = 0; i < linhas; i++)
                texto.Add(LerLinha());

            return texto;
        }

        public int CalcularMaiorLinha(List<string> texto)
        {
            return texto.OrderByDescending(t => t.Length).FirstOrDefault().Length;
        }
    }
}
