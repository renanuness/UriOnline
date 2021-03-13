using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ExerciciosAdHoc.Exercicio2175
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2175();
            ex.Executar();
        }
    }

    public class Ex2175
    {
        public void Executar()
        {
            var valores = LerMultiplasEntradas(3);

            var indexMenor = 0;
            var menor = 101.0;

            for (int i = 0; i < valores.Length; i++)
            {
                var valor = valores[i];
                if (valor < menor)
                {
                    indexMenor = i;
                    menor = valor;
                }
            }

            var empate = valores.Where(x => x == menor).ToList();
            if (empate.Count > 1)
                indexMenor = 4;

            var vencedor = "";
            switch(indexMenor){
                case 0:
                    vencedor = "Otavio";
                    break;
                case 1:
                    vencedor = "Bruno";
                    break;
                case 2:
                    vencedor = "Ian";
                    break;
                case 4:
                    vencedor = "Empate";
                    break;
            }

            Console.Write("{0}\n", vencedor);
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
