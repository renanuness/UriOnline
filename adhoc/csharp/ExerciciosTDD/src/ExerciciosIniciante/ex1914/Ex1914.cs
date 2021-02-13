using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio1914
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1914();
            ex.Executar();
        }
    }

    public class Ex1914
    {
        public void Executar()
        {
            var partida = new Partida();
            partida.Executar();
        }
    }

    public class Partida
    {
        public Jogador JogadorA { get; set; }
        public Jogador JogadorB { get; set; }

        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                LerPartida();
            }
        }

        public void LerPartida()
        {
            var entrada = LerLinha();
            LerJogadores(entrada);
            ImprimirVencedor();
        }

        private void LerJogadores(string entrada)
        {
            var entradaArray = entrada.Split(' ');
            var valores = LerMultiplasEntradas(2);

            JogadorA = new Jogador(entradaArray[0], valores[0], entradaArray[1]);
            JogadorB = new Jogador(entradaArray[2], valores[1], entradaArray[3]);
        }

        private void ImprimirVencedor()
        {
            var resultado = (JogadorA.Valor + JogadorB.Valor) % 2 == 0 ? PAR_IMPAR.PAR : PAR_IMPAR.IMPAR;

            string vencedor = JogadorA.Nome;
            if (JogadorB.Escolha == resultado)
                vencedor = JogadorB.Nome;

            Console.Write("{0}\n", vencedor);
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

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
        }
    }

    public class Jogador
    {
        public string Nome { get; set; }
        public int Valor { get; set; }
        public PAR_IMPAR Escolha { get; set; }
        public Jogador(string nome, int valor, string escolha)
        {
            Nome = nome;
            Valor = valor;
            Escolha = escolha == "PAR" ? PAR_IMPAR.PAR : PAR_IMPAR.IMPAR;
        }
    }

    public enum PAR_IMPAR
    {
        PAR,
        IMPAR
    }
}
