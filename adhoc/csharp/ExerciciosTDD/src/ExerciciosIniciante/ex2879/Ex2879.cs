using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.ex2879
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2879();
            ex.Executar();
        }
    }

    public class Ex2879
    {
        public void Executar()
        {
            var vezesQueGanhou = 0;
            var casosDeTeste = LerInteiro();

            while(casosDeTeste-- > 0)
            {
                var entrada = LerInteiro();
                if(entrada != 1)
                {
                    vezesQueGanhou++;
                }
            }

            Console.Write("{0}\n", vezesQueGanhou);
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        public int LerInteiro()
        {
            return int.Parse(LerLinha());
        }
    }
}
