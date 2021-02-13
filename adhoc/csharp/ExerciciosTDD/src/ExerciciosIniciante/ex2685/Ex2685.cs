using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2685
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2685();
            ex.Executar();
        }
    }
    public class Ex2685
    {
        public void Executar()
        {
            while (true)
            {
                var entrada = LerLinha();
                if (string.IsNullOrEmpty(entrada))
                    break;

                var inclinacao = LerInteiro(entrada);
                var resto = inclinacao / 90;
                var mensagem = "";

                if (resto == 0 || resto == 4)
                    mensagem = "Bom Dia!!";

                if (resto == 1)
                    mensagem = "Boa Tarde!!";

                if (resto == 2)
                    mensagem = "Boa Noite!!";

                if (resto == 3)
                    mensagem = "De Madrugada!!";

                Console.Write("{0}\n", mensagem);
            }
        }

        private int LerInteiro(string entrada)
        {
            return int.Parse(entrada);
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }
}
