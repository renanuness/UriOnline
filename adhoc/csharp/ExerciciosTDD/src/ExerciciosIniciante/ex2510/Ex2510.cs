using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2510
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2510();
            ex.Executar();
        }
    }

    public class Ex2510
    {
        public void Executar()
        {
            var casos = LerCasosDeTeste();
            while(casos-- > 0)
            {
                LerLinha();
                Console.Write("Y\n");
            }
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        public int LerCasosDeTeste()
        {
            return int.Parse(LerLinha());
        }
    }
}
