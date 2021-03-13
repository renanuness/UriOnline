using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosStrings.Exercicio1581
{
    public class URI 
    {
        static void Main(string[] args)
        {
            var ex = new Ex1581();
            ex.Executar();
        }
    }

    public class Ex1581
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var numeroDeLinguas = LerInteiro();
                List<string> linguas = new List<string>();

                while(numeroDeLinguas-- > 0)
                {
                    linguas.Add(LerLinha());
                }

                var primeira = linguas[0];
                if(linguas.Any(x => x != primeira))
                {
                    Console.Write("ingles\n");
                }
                else
                {
                    Console.Write("{0}\n", primeira);
                }
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
