using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2552
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2552();
            ex.Executar();
        }
    }

    public class Ex2552
    {
        public void Executar()
        {
            string entrada = "";

            while(!string.IsNullOrEmpty(entrada = LerLinha()))
            {
                var linhasColunas = LerMultiplasEntradas(entrada);

                var linhas = linhasColunas[0];
                var colunas = linhasColunas[1];
                var tabuleiro = new Tabuleiro(linhas, colunas);

                tabuleiro.ImprimirResultado();
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

        private int[] LerMultiplasEntradas(string entrada)
        {
            int[] valores = new int[2];
            var entradaArray = entrada.Split(' ');
            for (int i = 0; i < 2; i++)
            {
                valores[i] = int.Parse(entradaArray[i]);
            }

            return valores;
        }
    }

    public class Tabuleiro
    {
        public int[,] _tabuleiro { get; private set; }
        public int _linhas { get; private set; }
        public int _colunas { get; private set; }

        public Tabuleiro(int linhas, int colunas)
        {
            _tabuleiro = new int[linhas, colunas];
            _linhas = linhas;
            _colunas = colunas;
            LerTabuleiro();
        }

        public void ImprimirResultado()
        {
            for(int i = 0; i < _linhas; i++)
            {
                for(int j = 0; j < _colunas; j++)
                {
                    Console.Write("{0}", LerNumeroDePaesEmVizinhos(i, j));
                }
                Console.Write("\n");
            }
        }

        public int LerNumeroDePaesEmVizinhos(int linha, int coluna)
        {
            var paes = 0;

            if (_tabuleiro[linha, coluna] == 1)
                return 9;

            for(int i = -1; i<2; i+=2)
            {
                var c = coluna + i;
                if (LerValor(linha, c) == 1)
                    paes++;

                var l = linha + i;
                if (LerValor(l, coluna) == 1)
                    paes++;
            }
            return paes;
        }

        private int LerValor(int linha, int coluna)
        {
            if (EstaDentroDoTabuleiro(linha, coluna))
            {
                var valor = _tabuleiro[linha, coluna];
                return valor;
            }
            return 0;
        }

        private bool EstaDentroDoTabuleiro(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0)
                return false;


            if (linha > _linhas - 1 || coluna > _colunas - 1)
                return false;

            return true;
        }

        private void LerTabuleiro()
        {
            for(int i = 0; i < _linhas; i++)
            {
                var entradas = LerMultiplasEntradas(_colunas);
                for (int j = 0; j < _colunas; j++)
                {
                    _tabuleiro[i, j] = entradas[j];
                }
            }
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
