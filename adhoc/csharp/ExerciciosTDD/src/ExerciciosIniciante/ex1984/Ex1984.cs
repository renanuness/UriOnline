using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio1984
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1984();
            ex.Executar();
        }
    }

    public class Ex1984
    {
        public void Executar()
        {
            var valor = LerLinha();

            for (int i = valor.Length - 1; i >= 0; i--)
                Console.Write("{0}", valor[i]);

            Console.Write("\n");
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

    }
}
