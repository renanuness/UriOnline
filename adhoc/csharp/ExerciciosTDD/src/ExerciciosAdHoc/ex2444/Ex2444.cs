using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosAdHoc.Exercicio2444
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2444();
            ex.Executar();
        }

        public static int Clamp(int volume, int v1, int v2)
        {
            if (volume < v1)
                return v1;

            if (volume > v2)
                return v2;

            return volume;
        }
    }

    public class Ex2444
    {
        public void Executar()
        {
            var entradas = LerMultiplasEntradas(2);

            var volume = entradas[0];
            var quantidadeTrocasDeVolume = entradas[1];

            var trocasDeVolume = LerMultiplasEntradas(quantidadeTrocasDeVolume);

            for (int i = 0; i < quantidadeTrocasDeVolume; i++)
            {
                volume += trocasDeVolume[i];
                volume = URI.Clamp(volume, 0, 100);
            }

            volume = URI.Clamp(volume, 0, 100);
            Console.Write("{0}\n", volume);
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
