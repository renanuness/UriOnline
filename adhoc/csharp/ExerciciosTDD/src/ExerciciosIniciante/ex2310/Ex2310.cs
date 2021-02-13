using System;

namespace ExerciciosIniciante.Exercicio2310
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2310();
            ex.Executar();
        }
    }

    public class Ex2310
    {
        private int TotalSaques;
        private int TotalAtaques;
        private int TotalBloqueios;
        private int PontosSaques;
        private int PontosAtaques;
        private int PontosBloqueios;

        public void Executar()
        {
            var numeroDeJogadores = LerInteiro();

            for(int i = 0; i < numeroDeJogadores; i++)
            {
                LerJogador();
            }

           
            Console.Write("Pontos de Saque: {0:f2} %.\n", CalcularPorcentagem(TotalSaques, PontosSaques));
            Console.Write("Pontos de Bloqueio: {0:f2} %.\n", CalcularPorcentagem(TotalBloqueios, PontosBloqueios));
            Console.Write("Pontos de Ataque: {0:f2} %.\n", CalcularPorcentagem(TotalAtaques, PontosAtaques));
        }

        private void LerJogador()
        {
            LerLinha();

            var tentativas = LerMultiplasEntradas(3);
            var sucessos = LerMultiplasEntradas(3);

            TotalSaques += tentativas[0];
            TotalBloqueios += tentativas[1];
            TotalAtaques += tentativas[2];

            PontosSaques += sucessos[0];
            PontosBloqueios += sucessos[1];
            PontosAtaques += sucessos[2];
        }

        private double CalcularPorcentagem(int total, int valor)
        {
            var porcentagem = valor * 100 / (double)total;
            return porcentagem;
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
