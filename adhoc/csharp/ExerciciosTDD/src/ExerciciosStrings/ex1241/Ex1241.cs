using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.Exercicio1241
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1241();
            ex.Executar();
        }
    }

    public class Ex1241
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var entradas = LerLinha().Split(' ');

                var segundaComprimento = entradas[1].Length;
                var primeiraComprimento = entradas[0].Length;

                if (segundaComprimento > primeiraComprimento)
                {
                    Console.Write("nao encaixa\n");
                    continue;
                }
                var startIndex = primeiraComprimento - segundaComprimento;
                var final = entradas[0].Substring(startIndex, segundaComprimento);

                if (final == entradas[1])
                    Console.Write("encaixa\n");
                else
                    Console.Write("nao encaixa\n");
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
