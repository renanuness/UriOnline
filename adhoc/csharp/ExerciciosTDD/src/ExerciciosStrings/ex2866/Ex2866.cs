using System;
using System.Text;

namespace ExerciciosStrings.Exercicio2866
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2866();
            ex.Executar();
        }
    }

    public class Ex2866
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var linha = LerLinha();

                var sb = new StringBuilder();
                for(int i = linha.Length-1; i >= 0; i--)
                {
                    var l = linha[i];
                    if (l >= 97 && l <= 122)
                        sb.Append(l);
                }

                Console.Write("{0}\n", sb.ToString());
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
