using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.ex1129
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1129();
            ex.Executar();
        }
    }

    public class Ex1129
    {
        private readonly int NUMERO_QUESTOES = 5;
        public char Resposta { get; private set; }

        public void Executar()
        {
            while (true)
            {
                int casosDeTeste = LerCasosDeTeste();

                if (casosDeTeste == 0)
                    return;

                while (casosDeTeste-- > 0)
                {
                    var entradas = LerMultiplasEntradas(NUMERO_QUESTOES);
                    var escolhaCerta = -1;
                    Resposta = '?';

                    for (int i = 0; i < NUMERO_QUESTOES; i++)
                    {
                        if (entradas[i] <= 127 && Resposta == '?')
                        {
                            if (escolhaCerta == -1)
                                escolhaCerta = i;
                            else
                                Resposta = '*';
                        }
                    }

                    if(Resposta == '?')
                    Resposta = ConverterIntToResposta(escolhaCerta);

                    Console.Write("{0}\n", Resposta);
                }
            }
        }

        private char ConverterIntToResposta(int escolhaCerta)
        {
            switch (escolhaCerta)
            {
                case 0:
                    return 'A';
                case 1:
                    return 'B';
                case 2:
                    return 'C';
                case 3:
                    return 'D';
                case 4:
                    return 'E';
                default:
                    return '*';
            }
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        public int LerCasosDeTeste()
        {
            return int.Parse(LerLinha());
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
