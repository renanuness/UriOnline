using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1329
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1329();
            ex.Executar();
        }
    }

    public class Ex1329
    {
        public void Executar()
        {
            var partidas = 0;
            while((partidas = LerInteiro()) > 0)
            {
                var entradas = LerMultiplasEntradas(partidas);

                var mary = 0;
                var john = 0;
                for(int i = 0; i < partidas; i++)
                {
                    if (entradas[i] == 0)
                        mary++;
                    else
                        john++;
                }

                Console.Write("Mary won {0} times and John won {1} times\n", mary, john);
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
