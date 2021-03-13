using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio2427
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2427();
            ex.Executar();
        }
    }

    public class Ex2427
    {
        public void Executar()
        {
            var tamanho = double.Parse(Console.ReadLine());

            var lados = 1;
            var tamanhoAtual = tamanho * tamanho;

            while(tamanhoAtual >= 4)
            {
                tamanhoAtual /= 4;
                lados *= 4;
            }

            Console.Write("{0}\n", lados);
        }
    }
}
