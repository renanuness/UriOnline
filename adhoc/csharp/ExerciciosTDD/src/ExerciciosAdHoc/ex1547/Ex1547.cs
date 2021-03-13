using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1547
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1547();
            ex.Executar();
        }
    }
    public class Ex1547
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var entradas1 = LerMultiplasEntradas(2);
                var quantidadeNumeros = entradas1[0];
                var pessoaAcertadora = -1;
                var alvo = entradas1[1];
                var escolhido = int.MaxValue;
                
                var entradas2 = LerMultiplasEntradas(quantidadeNumeros);

                for(int i = 0; i< quantidadeNumeros; i++)
                {
                    var valorAtual = entradas2[i];
                    var diferencaValorAtual = Math.Abs(alvo - valorAtual);
                    var diferencaEscolhido = Math.Abs(alvo - escolhido);
                    if (diferencaValorAtual < diferencaEscolhido)
                    {
                        escolhido = valorAtual;
                        pessoaAcertadora = i + 1;
                    }
                }

                Console.Write("{0}\n", pessoaAcertadora);
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
}
