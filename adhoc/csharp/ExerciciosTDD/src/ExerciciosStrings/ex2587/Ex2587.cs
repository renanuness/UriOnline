using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.Exercicio2587
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2587();
            ex.Executar();
        }
    }

    public class Ex2587
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var p1 = LerLinha();
                var p2 = LerLinha();

                var pAtual = LerLinha();

                p1 = EliminarLetrasConhecidas(p1, pAtual);
                p2 = EliminarLetrasConhecidas(p2, pAtual);
                TestarPalpite(p1, p2);
            }
        }

        private string EliminarLetrasConhecidas(string palavra, string letras)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < palavra.Length; i++)
            {
                var l = palavra[i];

                if (letras[i] != l)
                    sb.Append(l);
            }
            return sb.ToString();
        }

        private void TestarPalpite(string p1, string p2)
        {
            if(p1[0] == p2[1] || p1[1] == p2[0])
                Console.Write("Y\n");
            else
                Console.Write("N\n");
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

    }
}
