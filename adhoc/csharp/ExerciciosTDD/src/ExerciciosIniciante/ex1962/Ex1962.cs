using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio1962
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1962();
            ex.Executar();
        }
    }

    public class Ex1962
    {
        public void Executar()
        {
            var casos = LerInteiro();

            while(casos-- > 0)
            {
                var numeroDeAnos = LerInteiro();

                var ano = 2015 - numeroDeAnos;

                if(ano <= 0)
                {
                    ano--;
                    ano *= -1;
                    Console.Write("{0} A. C.\n", ano);
                    continue;
                }

                Console.Write("{0} D. C.\n", ano);
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
