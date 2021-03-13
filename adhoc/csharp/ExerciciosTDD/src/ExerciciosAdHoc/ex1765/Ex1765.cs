using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1765
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1765();
            ex.Executar();
        }
    }

    public class Ex1765
    {
        public void Executar()
        {
            var casos = 0;
            var altura = 5;
            while((casos = LerInteiro()) > 0)
            {
                for (int i = 0; i < casos; i++)
                {
                    var entradas = LerMultiplasEntradas(3);

                    var resultado = ((entradas[1] + entradas[2]) * altura) / 2;
                    resultado *= entradas[0];

                    Console.Write("Size #{0}:\n", i+1);
                    Console.Write("Ice Cream Used: {0:f2} cm2\n", resultado);
                }
                Console.Write("\n");
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
