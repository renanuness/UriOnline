using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2749
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2749();
            ex.Executar();
        }
    }

    public class Ex2749
    {
        public void Executar()
        {
            ImprimirCaracterRepetido('-', 39);
            ImprimirNovaLinha();

            ImprimirTraco();
            ImprimirX35();
            ImprimirCaracterRepetido(' ', 31);
            ImprimirTraco();
            ImprimirNovaLinha();

            ImprimirTraco();
            ImprimirCaracterRepetido(' ', 37);
            ImprimirTraco();
            ImprimirNovaLinha();

            ImprimirTraco();
            ImprimirCaracterRepetido(' ', 15);
            ImprimirX35();
            ImprimirCaracterRepetido(' ', 16);
            ImprimirTraco();
            ImprimirNovaLinha();

            ImprimirTraco();
            ImprimirCaracterRepetido(' ', 37);
            ImprimirTraco();
            ImprimirNovaLinha();

            ImprimirTraco();
            ImprimirCaracterRepetido(' ', 31);
            ImprimirX35();
            ImprimirTraco();
            ImprimirNovaLinha();

            ImprimirCaracterRepetido('-', 39);
            ImprimirNovaLinha();
        }

        private void ImprimirCaracterRepetido(char c, int x)
        {
            for (int i = 0; i < x; i++)
                Console.Write("{0}", c);
        }

        private void ImprimirNovaLinha()
        {
            Console.Write("\n");
        }

        private void ImprimirX35()
        {
            Console.Write("x = 35");
        }

        private void ImprimirTraco()
        {
            Console.Write("|");
        }
    }
}
