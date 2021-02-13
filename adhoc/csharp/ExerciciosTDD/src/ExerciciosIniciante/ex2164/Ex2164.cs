using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2164
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2164();
            ex.Executar();
        }
    }

    public class Ex2164
    {
        public void Executar()
        {
            var raizDeCinco = Math.Sqrt(5);
            var n = LerInteiro();

            var umMaisRaizDeCincoSobreDois =  ((1 + raizDeCinco) / 2);
            var umMenosRaizDeCincoSobreDois = ((1 - raizDeCinco) / 2);

            var primeiro = Math.Pow(umMaisRaizDeCincoSobreDois, n);
            var segundo = Math.Pow(umMenosRaizDeCincoSobreDois, n);

            var dividendo = primeiro - segundo;

            var resultado = dividendo / raizDeCinco;

            Console.Write("{0:f1}\n", resultado);
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
