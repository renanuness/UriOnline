using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1715
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1715();
            ex.Executar();
        }
    }

    public class Ex1715
    {
        public void Executar()
        {
            List<Jogador> Jogadores = new List<Jogador>();
            var entradas = LerMultiplasEntradas(2);
            var numeroDeJogadores = entradas[0];
            var numeroDePartidas = entradas[1];

            for(int i = 0; i < numeroDeJogadores; i++)
            {
                var partidas = LerMultiplasEntradas(numeroDePartidas);
                var jogador = new Jogador();
                jogador.Partidas = partidas.ToList();
                Jogadores.Add(jogador);
            }

            int artilheiros = 0;

            foreach(var jogador in Jogadores){
                if (jogador.FezGolEmTodasPartidas())
                    artilheiros++;
            }

            Console.Write("{0}\n", artilheiros);
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

    public class Jogador
    {
        public List<int> Partidas { get; set; }

        public bool FezGolEmTodasPartidas()
        {
            foreach(var partida in Partidas)
            {
                if (partida == 0)
                    return false;
            }

            return true;
        }
    }
}
