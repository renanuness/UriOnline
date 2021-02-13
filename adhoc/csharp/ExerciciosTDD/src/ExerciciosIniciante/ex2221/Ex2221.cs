using System;

namespace ExerciciosIniciante.Exercicio2221
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2221();
            ex.Executar();
        }
    }

    public class Ex2221
    {
        public void Executar()
        {
            var partidas = LerInteiro();

            while(partidas-- > 0)
            {
                var bonus = LerInteiro();

                var dabriel = LerMultiplasEntradas(3);
                var guarte = LerMultiplasEntradas(3);

                var pontosDabriel = (dabriel[0] + dabriel[1]) / 2;
                pontosDabriel = dabriel[2] % 2 == 0 ? pontosDabriel + bonus : pontosDabriel;
                
                var pontosGuarte = (guarte[0] + guarte[1]) / 2;
                pontosGuarte = guarte[2] % 2 == 0 ? pontosGuarte + bonus : pontosGuarte;

                if (pontosDabriel > pontosGuarte)
                    Console.Write("Dabriel\n");
                else if (pontosDabriel < pontosGuarte)
                    Console.Write("Guarte\n");
                else
                    Console.Write("Empate\n");
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
