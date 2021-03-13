using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1089
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1089();
            ex.Executar();
        }
    }

    public class Ex1089
    {
        public void Executar()
        {
            var resultado = new List<int>();

            var casos = 0;

            while ((casos = LerInteiro()) != 0)
            {
                var entradas = LerMultiplasEntradas(casos);

                var ultimoValor = entradas[casos - 1];
                var valorAtual = entradas[0];
                var primeiroValor = valorAtual;

                var sentido = valorAtual < entradas[1] ? SENTIDO.SUBINDO : SENTIDO.DESCENDO;
                var primeiroSentido = sentido;
                var picos = 0;

                if (casos <= 2)
                {
                    picos = 2;
                    resultado.Add(picos);
                    continue;
                }
                for (int i = 0; i < casos; i++)
                {
                    var valor = entradas[i];
                    var proximoValor = i + 1 < casos ? entradas[i + 1] : primeiroValor;

                    if (sentido == SENTIDO.DESCENDO && proximoValor > valor)
                    {
                        picos++;
                        sentido = SENTIDO.SUBINDO;
                    }

                    if (sentido == SENTIDO.SUBINDO && proximoValor < valor)
                    {
                        picos++;
                        sentido = SENTIDO.DESCENDO;
                    }
                    if(i == casos - 1 && sentido != primeiroSentido)
                    {
                        if (sentido == SENTIDO.DESCENDO && proximoValor < valor)
                        {
                            picos++;
                        }
                        if(sentido == SENTIDO.SUBINDO && proximoValor > valor)
                        {
                            picos++;
                        }
                    }
                }
                resultado.Add(picos);
            }
            resultado.ForEach(x => Console.Write("{0}\n", x));
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

    public enum SENTIDO
    {
        SUBINDO,
        DESCENDO
    }
}
