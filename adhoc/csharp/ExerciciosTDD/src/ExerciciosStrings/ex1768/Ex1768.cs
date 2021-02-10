using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.ex1768
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1768();
            ex.Executar();
        }
    }

    public class Ex1768
    {
        public int TamanhoArvore { get; private set; }

        public void Executar()
        {
            while (true)
            {
                var entrada = LerLinha();

                if (entrada == "")
                    return;

                TamanhoArvore = LerInteiro(entrada);
                ImprimirArvore();
            }
        }

        private void ImprimirArvore()
        {
            for(int i = 1; i <= TamanhoArvore; i+=2)
            {
                var espacosEmBranco = (TamanhoArvore - i) / 2;
                ImprimirEspacoEmBranco(espacosEmBranco);
                ImprimirAsteriscos(i);
                QuebrarLinha();
            }
            ImprimirPe();
        }

        private void ImprimirAsteriscos(int quantiade)
        {
            for (int i = 0; i < quantiade; i++)
            {
                Console.Write("*");
            }
        }

        private void ImprimirEspacoEmBranco(int quantiade)
        {
            for(int i = 0; i < quantiade; i++)
            {
                Console.Write(" ");
            }
        }

        private void ImprimirPe()
        {
            ImprimirEspacoEmBranco((TamanhoArvore-1) / 2);
            ImprimirAsteriscos(1);
            QuebrarLinha();
            ImprimirEspacoEmBranco((TamanhoArvore - 3) / 2);
            ImprimirAsteriscos(3);
            QuebrarLinha();
        }

        private void QuebrarLinha()
        {
            Console.Write("\n");
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
