using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.Exercicio1803
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1803();
            ex.Executar();
        }
    }

    public class Ex1803
    {
        public void Executar()
        {
            List<string> mating = new List<string>();

            var linhas = 4;
            while (linhas-- > 0)
                mating.Add(LerLinha());

            var inteiros = MatingToInt(mating);

            Traduzir(inteiros);
        }

        private void Traduzir(List<int> inteiros)
        {
            StringBuilder mensagem = new StringBuilder();
            var ultimo = inteiros.Count -1;
            //0-4 l = 5 l-2= 3
            for (int i = 1; i < ultimo; i++)
            {
                var valor = inteiros[0] * inteiros[i] + inteiros[ultimo];
                char c = (char)(valor % 257);
                mensagem.Append(c);
            }

            Console.Write("{0}\n", mensagem.ToString());

        }

        private List<int> MatingToInt(List<string> mating)
        {
            List<string> novaLista = new List<string>();
            for(int i = 0; i < mating[0].Length; i++)
                novaLista.Add("");

            for (int i = 0; i < mating.Count; i++)
            {
                var linha = mating[i];
                for (int j = 0; j <= linha.Length-1; j++)
                {
                    novaLista[j] += linha[j];
                }
            }

            List<int> inteiros = new List<int>();
            foreach (var linha in novaLista)
                inteiros.Add(int.Parse(linha));

            return inteiros;
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }
}
