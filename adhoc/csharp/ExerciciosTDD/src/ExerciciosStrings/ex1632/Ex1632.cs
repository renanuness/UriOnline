using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.ex1632
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1632();
            ex.Executar();
        }
    }

    public class Ex1632
    {
        public void Executar()
        {
            var casosDeTeste = LerInteiro();

            while(casosDeTeste-- > 0)
            {
                var entrada = LerLinha();
                var variacoes = AnalisarSenha(entrada);

                Console.Write("{0}\n", variacoes);
            }
        }

        private int AnalisarSenha(string senha)
        {
            var variacoes = 1;
            foreach(var caractere in senha)
            {
                variacoes *= DefinirPeso(caractere.ToString());
            }

            return variacoes;
        }

        private int DefinirPeso(string c)
        {
            if (c.ToLower() == "a" || c.ToLower() == "e" || c.ToLower() == "i" || c.ToLower() == "o" || c.ToLower() == "s")
                return 3;
            
            return 2;
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
