using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio2415
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2415();
            ex.Executar();
        }
    }

    public class Ex2415
    {
        public void Executar()
        {
            var casos = LerInteiro();
            var entrada = LerLinha();

            var valores = entrada.Split(' ');

            var maiorSequencia = 0;
            var contagemAtual = 1;
            var contando = false;
            var ultimoValor = "";

            for (int i = 0; i < casos; i++)
            {
                if (i == 0)
                    ultimoValor = valores[i];
                else
                {
                    var iguais = valores[i] == ultimoValor;
                    if (iguais)
                    {
                        contagemAtual++;
                        contando = true;
                    }

                    if (contagemAtual > maiorSequencia)
                        maiorSequencia = contagemAtual;

                    if (!iguais)
                    {
                        contando = false;
                        contagemAtual = 1;
                    }
                    ultimoValor = valores[i];
                }
            }

            Console.Write("{0}\n", maiorSequencia);
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
