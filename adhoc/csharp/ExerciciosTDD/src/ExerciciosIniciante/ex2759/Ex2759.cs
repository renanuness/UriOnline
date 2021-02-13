using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2759
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2759();
            ex.Executar();
        }
    }

    public class Ex2759
    {
        public void Executar()
        {
            var a = LerLinha();
            var b = LerLinha();
            var c = LerLinha();

            Console.Write("A = {0}, B = {1}, C = {2}\n", a, b, c);
            Console.Write("A = {0}, B = {1}, C = {2}\n", b, c, a);
            Console.Write("A = {0}, B = {1}, C = {2}\n", c, a, b);
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }
}
