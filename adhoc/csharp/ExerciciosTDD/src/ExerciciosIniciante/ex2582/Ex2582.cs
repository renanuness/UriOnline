using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2582
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2582();
            ex.Executar();
        }
    }

    public class Ex2582
    {
        private Dictionary<int, string> musicas;

        public void Executar()
        {
            InicializarLista();
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var numeros = LerMultiplasEntradas(2);

                var soma = numeros[0] + numeros[1];

                var musica = musicas[soma];
                Console.Write("{0}\n", musica);
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
        
        private void InicializarLista()
        {
            musicas = new Dictionary<int, string>();

            musicas.Add(0, "PROXYCITY");
            musicas.Add(1, "P.Y.N.G.");
            musicas.Add(2, "DNSUEY!");
            musicas.Add(3, "SERVERS");
            musicas.Add(4, "HOST!");
            musicas.Add(5, "CRIPTONIZE");
            musicas.Add(6, "OFFLINE DAY");
            musicas.Add(7, "SALT");
            musicas.Add(8, "ANSWER!");
            musicas.Add(9, "RAR?");
            musicas.Add(10, "WIFI ANTENNAS");
        }
    }
}
