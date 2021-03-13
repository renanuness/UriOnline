using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1437
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1437();
            ex.Executar();
        }
    }

    public class Ex1437
    {
        public void Executar()
        {
            var casos = 0;
            while((casos = LerInteiro())!= 0)
            {
                var comandos = LerLinha();

                var comandoDireita = comandos.Where(x => x == 'D').Count();
                var comandoEsquerda = comandos.Where(x => x == 'E').Count();

                var direcao = comandoDireita - comandoEsquerda;

                var resto = direcao % 4;

                var sentido = "";

                if (resto == -3 || resto == 1)
                    sentido = "L";
                if (resto == -2 || resto == 2)
                    sentido = "S";
                if (resto == -1 || resto == 3)
                    sentido = "O";
                if (resto == 0)
                    sentido = "N";

                Console.Write("{0}\n", sentido);
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
