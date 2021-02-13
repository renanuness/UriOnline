using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio1864
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1864();
            ex.Executar();
        }
    }

    public class Ex1864
    {
        private const string TEXTO = "LIFE IS NOT A PROBLEM TO BE SOLVED";
        public void Executar()
        {
            var tamanhoString = LerInteiro();

            
            var novaString = tamanhoString < 34 ? TEXTO.Substring(0, tamanhoString) : TEXTO;

            Console.Write("{0}\n", novaString);
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
