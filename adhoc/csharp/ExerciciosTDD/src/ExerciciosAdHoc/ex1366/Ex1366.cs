using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1366
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1366();
            ex.Executar();
        }
    }

    public class Ex1366
    {
        public void Executar()
        {
            var varetas = 0;

            while ((varetas = LerInteiro()) != 0)
            {
                var retangulos = 0;
                var restos = 0;

                for (int i = 0; i < varetas; i++)
                {
                    var entrada = LerMultiplasEntradas(2);

                    var quantidadeVaretas = entrada[1];

                    retangulos += quantidadeVaretas / 4;

                    if (quantidadeVaretas % 4 >= 2)
                        restos++;
                }

                retangulos += restos / 2;

                Console.Write("{0}\n", retangulos);
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
    }
}
