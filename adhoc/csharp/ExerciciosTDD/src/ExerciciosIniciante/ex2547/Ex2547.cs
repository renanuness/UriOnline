using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2547
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2547();
            ex.Executar();
        }
    }

    public class Ex2547
    {
        public int VisitantesAptos { get; private set; }

        public Ex2547()
        {
            VisitantesAptos = 0;
        }

        public void Executar()
        {
            int[] entradas;

            while ((entradas = LerMultiplasEntradas(3)) != null)
            {
                VisitantesAptos = 0;

                var quantidadeVisitantes = entradas[0];
                var alturaMinima = entradas[1];
                var alturaMaxima = entradas[2];

                while (quantidadeVisitantes-- > 0)
                {
                    var altura = LerInteiro();
                    if (altura >= alturaMinima && altura <= alturaMaxima)
                        VisitantesAptos++;
                }
                Console.Write("{0}\n", VisitantesAptos);
            }
        }

        private int[] LerMultiplasEntradas(int entradas)
        {
            var entrada = LerLinha();

            if (string.IsNullOrEmpty(entrada))
                return null;

            int[] valores = new int[entradas];
            var entradaArray = entrada.Split(' ');
            for (int i = 0; i < entradas; i++)
            {
                valores[i] = int.Parse(entradaArray[i]);
            }

            return valores;
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
        }
    }
}
