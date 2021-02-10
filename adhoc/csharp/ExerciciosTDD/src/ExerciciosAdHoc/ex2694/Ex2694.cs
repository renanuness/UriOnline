using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExerciciosAdHoc.ex2694
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2694();
            int casosDeTeste = int.Parse(ex.LerLinha());

            for (int i = 0; i < casosDeTeste; i++)
            {
                var entrada = ex.LerLinha();
                var numeros = ex.ExtrairNumeros(entrada);
                Console.Write("{0}\n", ex.SomaValores(numeros));
            }
        }
    }

    public class Ex2694
    {
        public static int MAX_CASOS_TESTE = 100000;

        public string LerLinha()
        {
            return Console.ReadLine();
        }

        public bool ValidarCasosDeTeste(int casosDeTeste)
        {
            if (casosDeTeste >= MAX_CASOS_TESTE)
                return false;

            return true;
        }

        public List<int> ExtrairNumeros(string caracteres)
        {
            string azPattern = "[a-zA-Z]+";
            string[] result = Regex.Split(caracteres, azPattern);

            List<int> numeros = new List<int>();
            foreach (var valor in result)
            {
                int numero = 0;
                if (int.TryParse(valor, out numero))
                {
                    numeros.Add(numero);
                }
            }

            return numeros;
        }

        public int SomaValores(List<int> valores)
        {
            return valores.Sum();
        }
    }
}
