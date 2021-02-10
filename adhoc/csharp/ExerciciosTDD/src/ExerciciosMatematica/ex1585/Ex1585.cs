using System;

namespace ExerciciosMatematica.ex1585
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1585();
            ex.Executar();
        }
    }

    public class Ex1585
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var entradas = LerMultiplasEntradas(2);
                var resultado = (entradas[0] * entradas[1]) / 2;
                Console.Write("{0} cm2\n", resultado);
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
