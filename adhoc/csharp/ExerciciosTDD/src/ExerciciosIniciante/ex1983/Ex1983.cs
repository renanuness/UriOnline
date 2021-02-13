using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosIniciante.Exercicio1983
{
    public class URI 
    {
        static void Main(string[] args)
        {
            var ex = new Ex1983();
            ex.Executar();
        }
    }

    public class Ex1983
    {
        public void Executar()
        {
            var alunos = LerInteiro();

            double maiorNota = 0;
            double codigoMaiorNota = 0;

            while(alunos-- > 0)
            {
                var entrada = LerMultiplasEntradas(2);

                var nota = entrada[1];

                if(nota > maiorNota)
                {
                    codigoMaiorNota = entrada[0];
                    maiorNota = nota;
                }
            }

            if (maiorNota < 8)
                Console.Write("Minimum note not reached\n");
            else
                Console.Write("{0}\n", codigoMaiorNota);
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        private double[] LerMultiplasEntradas(int entradas)
        {
            var entrada = LerLinha();

            double[] valores = new double[entradas];
            var entradaArray = entrada.Split(' ');
            for (int i = 0; i < entradas; i++)
            {
                valores[i] = double.Parse(entradaArray[i], CultureInfo.InvariantCulture);
            }

            return valores;
        }
    }
}
