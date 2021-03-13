using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1890
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1890();
            ex.Executar();
        }
    }

    public class Ex1890
    {
        private const int NUMERO_DIGITOS = 10;
        private const int NUMERO_CONSOANTES = 26;
        public void Executar()
        {
            var casos = LerInteiro();

            while (casos-- > 0)
            {
                var entradas = LerMultiplasEntradas(2);

                var consoantes = entradas[0];
                var digitos = entradas[1];

                if(consoantes == 0 && digitos == 0)
                {
                    Console.Write("{0}\n", 0);
                    continue;
                }

                var resultado = Math.Pow(NUMERO_CONSOANTES, consoantes) * Math.Pow(NUMERO_DIGITOS, digitos);

                Console.Write("{0}\n", resultado);
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
