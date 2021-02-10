using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.ex2451
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2451();
            ex.Executar();
        }
    }
    public class Ex2451
    {
        public int Linhas { get; private set; }
        public List<string> Entradas { get; private set; }
        public int MaiorValor { get; private set; }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
        }

        public void Executar()
        {
            Entradas = new List<string>();
            Linhas = LerInteiro();
            LerEntradas();
            AnalisarEntradas();
            Console.Write("{0}\n", MaiorValor);
        }

        private void LerEntradas()
        {
            for (int linha = 0; linha < Linhas; linha++)
            {
                Entradas.Add(LerLinha());
            }
        }

        private void AnalisarEntradas()
        {
            int sequencia = 0;
            for (int linha = 0; linha < Linhas; linha++)
            {
                if(linha % 2 == 0)
                {
                    for (int coluna = 0; coluna < Linhas; coluna++)
                    {
                        var caractere = Entradas[linha][coluna];
                        if (EhComida(caractere))
                            sequencia++;
                        else if (EhInimigo(caractere))
                            sequencia = 0;

                        ComputarMaiorValor(sequencia);
                    }
                }
                else
                {
                    for (int coluna = Linhas-1; coluna >= 0; coluna--)
                    {
                        var caractere = Entradas[linha][coluna];
                        if (EhComida(caractere))
                            sequencia++;
                        else if (EhInimigo(caractere))
                            sequencia = 0;

                        ComputarMaiorValor(sequencia);
                    }
                }
            }
        }

        private bool EhComida(char caractere) => caractere == 'o';

        private bool EhInimigo(char caractere) => caractere == 'A';

        private void ComputarMaiorValor(int sequencia)
        {
            if (sequencia > MaiorValor)
                MaiorValor = sequencia;
        }

    }
}
