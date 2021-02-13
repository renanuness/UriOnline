using System;
using System.Linq;
using System.Text;

namespace ExerciciosStrings.Exercicio2242
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2242();
            ex.Executar();
        }
    }

    public class Ex2242
    {
        public void Executar()
        {
            var risada = Console.ReadLine();

            var vogais = ExtrairConsoantes(risada);
            CompararVogais(vogais);
        }

        private void CompararVogais(string vogais)
        {
            var sb = new StringBuilder();
            for(int i = vogais.Length-1; i >= 0; i--)
                sb.Append(vogais[i]);

            if (vogais == sb.ToString())
                Console.Write("S\n");
            else
                Console.Write("N\n");
        }

        private string ExtrairConsoantes(string risada)
        {
            char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var sb = new StringBuilder();
            for(int i = 0; i < risada.Length; i++)
            {
                var l = risada[i];
                if (vogais.Contains(l))
                    sb.Append(l);
            }
            return sb.ToString();
        }
    }
}
