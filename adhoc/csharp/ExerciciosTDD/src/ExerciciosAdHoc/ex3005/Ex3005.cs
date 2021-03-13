using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosAdHoc.Exercicio3005
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex3005();
            ex.Executar();
        }
    }

    public class Ex3005
    {
        public void Executar()
        {
            var casos = LerInteiro();

            while(casos-- > 0)
            {
                var entradas = LerMultiplasEntradas(6);

                var p1 = new Paralelepipedo(entradas[0], entradas[1], entradas[2]);
                var p2 = new Paralelepipedo(entradas[3], entradas[4], entradas[5]);

                var p1Suporta = p1.PodeSuportar(p2);
                var p2Suporta = p2.PodeSuportar(p1);

                var saida = 0;
                if (p1Suporta && p2Suporta)
                    saida = 3;
                else if (p1Suporta)
                    saida = 2;
                else if (p2Suporta)
                    saida = 1;
                else if (!p1Suporta && !p2Suporta)
                    saida = 0;

                Console.Write("{0}\n", saida);
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

    public class Paralelepipedo
    {
        public int[] Lados;

        public Paralelepipedo(int l1, int l2, int l3)
        {
            Lados = new int[] { l1, l2, l3 };
            Lados = Lados.OrderByDescending(x => x).ToArray();
        }

        public bool PodeSuportar(Paralelepipedo p2)
        {
            if (Lados[0] > p2.Lados[1] && Lados[1] > p2.Lados[2])
                return true;

            return false;
        }
    }
}
