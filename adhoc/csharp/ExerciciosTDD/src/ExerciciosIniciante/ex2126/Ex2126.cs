using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2126
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2126();
            ex.Executar();
        }
    }

    public class Ex2126
    {
        public int Caso { get; set; }
        public string Valor { get; set; }
        string Valores { get; set; }

        public void Executar()
        {
            Caso = 1;
            while (!string.IsNullOrEmpty(Valor = LerLinha()))
            {
                Valores = LerLinha();

                EncontrarSubStrings();
                Caso++;
            }
        }

        private void EncontrarSubStrings()
        {
            if (Valores.Contains(Valor))
            {
                var matchString = new ComparadorString(Valor, Valores);
                var pos = matchString.UltimaPosicao;
                var matchs = matchString.Matchs;

                Imprimir(matchs, pos);
            }
            else
            {
                Imprimir(0, 0);
            }
        }

        private void Imprimir(int quantidade, int posicao)
        {
            Console.Write("Caso #{0}:\n", Caso);
            if (quantidade == 0)
                Console.Write("Nao existe subsequencia\n");
            else
            {
                Console.Write("Qtd.Subsequencias: {0}\n", quantidade);
                Console.Write("Pos: {0}\n", posicao);
            }
            Console.Write("\n");
        }
        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }

    public class ComparadorString
    {
        private int _index;
        private int _matchs;
        private string _Valor;
        private string Texto;
        public int Matchs => _matchs;
        private int _Comprimento => _Valor.Length;

        public int UltimaPosicao { get; private set; }

        public ComparadorString(string valor, string texto)
        {
            _Valor = valor;
            Texto = texto;
            ContarMatchsSubstring();
        }

        private int ContarMatchsSubstring()
        {
            var textoComprimento = Texto.Length;
            for (int i = 0; i < textoComprimento; i++)
            {
                if (i + _Comprimento > textoComprimento)
                    break;

                var subString = Texto.Substring(i, _Comprimento);
                if (subString == _Valor)
                {
                    _matchs++;
                    UltimaPosicao = i + 1;
                }
            }
            return _matchs;
        }

        private bool CompararPalavra(char k)
        {
            var retorno = false;
            if (k == _Valor[_index])
            {
                retorno = true;
                if (_index == _Valor.Length - 1)
                {
                    _matchs++;
                    _index = 0;
                }
                else
                    _index++;
            }
            return retorno;
        }
    }
}
