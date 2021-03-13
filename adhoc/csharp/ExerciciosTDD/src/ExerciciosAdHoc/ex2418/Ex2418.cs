using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ExerciciosAdHoc.Exercicio2418
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2418();
            ex.Executar();
        }
    }

    public class Ex2418
    {
        public void Executar()
        {
            var notas = LerMultiplasEntradas(5);

            notas = notas.OrderBy(x => x).ToArray();

            var notaFinal = 0.0;
            for (int i = 1; i < notas.Length - 1; i++)
                notaFinal += notas[i];

            Console.Write("{0:f1}\n", notaFinal);
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

            if (string.IsNullOrEmpty(entrada))
                return null;

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
