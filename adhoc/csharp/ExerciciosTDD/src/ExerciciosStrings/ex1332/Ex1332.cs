using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.Exercicio1332
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1332();
            ex.Executar();
        }
    }

    public class Ex1332
    {
        public void Executar()
        {
            List<string> palavras = new List<string>();
            palavras.Add("one");
            palavras.Add("two");
            palavras.Add("three");

            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var tentativa = LerLinha();

                for(int i = 0; i < palavras.Count; i++)
                {
                    if(Comparar(palavras[i], tentativa))
                    {
                        Console.Write("{0}\n", i + 1);
                        break;
                    }
                }
            }
        }

        private bool Comparar(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            var matchs = 0;
            for(int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                    matchs++;
            }

            return matchs >= s1.Length-1;
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
