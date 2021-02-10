using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.ex2756
{
    public class URI
    {
        static void Main(string[] args) 
        { 
            var ex = new Ex2756();
            ex.Executar();
        }
    }

    public class Ex2756
    {
        public void Executar()
        {
            PrintA();
            PrintB();
            PrintC();
            PrintD();
            PrintE();
            PrintD();
            PrintC();
            PrintB();
            PrintA();
        }

        private void PrintA()
        {
            PrintEspacosEmBranco(7);
            PrintCaractere('A');
            QuebrarLinha();
        }

        private void PrintB()
        {
            PrintEspacosEmBranco(6);
            PrintCaractere('B');
            PrintEspacosEmBranco(1);
            PrintCaractere('B');
            QuebrarLinha();

        }

        private void PrintC()
        {
            PrintEspacosEmBranco(5);
            PrintCaractere('C');
            PrintEspacosEmBranco(3);
            PrintCaractere('C');
            QuebrarLinha();
        }

        private void PrintD()
        {
            PrintEspacosEmBranco(4);
            PrintCaractere('D');
            PrintEspacosEmBranco(5);
            PrintCaractere('D');
            QuebrarLinha();
        }

        private void PrintE()
        {
            PrintEspacosEmBranco(3);
            PrintCaractere('E');
            PrintEspacosEmBranco(7);
            PrintCaractere('E');
            QuebrarLinha();
        }

        public void PrintCaractere(char caractere)
        {
            Console.Write("{0}", caractere);
        }

        public void PrintEspacosEmBranco(int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
                Console.Write(" ");
        }

        public void QuebrarLinha()
        {
            Console.Write("\n");
        }
    }
}
