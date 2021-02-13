using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosStrings.Exercicio2591
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2591();
            ex.Executar();
        }
    }

    public class Ex2591
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var linha = LerLinha();

                var metades = linha.Split('e');

                int a1 = metades[0].Where(x => x.Equals('a')).Count();
                int a2 = metades[1].Where(x => x.Equals('a')).Count();
                var total = a1 * a2;

                var sb = new StringBuilder();
                sb.Append("k");
                for (int i = 0; i < total; i++)
                    sb.Append("a");

                Console.Write("{0}\n", sb);
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
