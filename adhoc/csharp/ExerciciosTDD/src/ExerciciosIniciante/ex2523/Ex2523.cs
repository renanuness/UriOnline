using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2523
{
    public static class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2523();
            ex.Executar();
        }
    }

    public class Ex2523
    {
        public void Executar()
        {
            var letras = "";
            while (!string.IsNullOrWhiteSpace(letras = LerLinha()))
            {
                var tamanhoDaMensagem = LerInteiro();
                var mensagem = LerMultiplasEntradas(tamanhoDaMensagem);

                var mensagemDecodificada = new StringBuilder();
                for(int i = 0; i < tamanhoDaMensagem; i++)
                {
                    var l = mensagem[i]-1;
                    mensagemDecodificada.Append(letras[l]);
                }
                Console.Write("{0}\n", mensagemDecodificada);
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
