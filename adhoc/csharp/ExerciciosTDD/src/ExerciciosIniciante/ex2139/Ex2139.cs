using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2139
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2139();
            ex.Executar();
        }
    }

    public class Ex2139
    {
        public void Executar() 
        {
            DateTime natal = new DateTime(2016, 12, 25);
            int[] data;
            while ((data = LerMultiplasEntradas(2)) != null)
            {
                DateTime dataEntrada = new DateTime(2016, data[0], data[1]);

                var diasParaONatal = (natal - dataEntrada).Days;

                var mensagem = "";
                if (diasParaONatal == 0)
                    mensagem = "E natal!";
                else if (diasParaONatal == 1)
                    mensagem = "E vespera de natal!";
                else if (diasParaONatal < 0)
                    mensagem = "Ja passou!";
                else
                    mensagem = $"Faltam {diasParaONatal} dias para o natal!";

                Console.Write("{0}\n", mensagem);
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

    }
}
