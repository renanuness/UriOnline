using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ExerciciosStrings.Exercicio1868
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1868();
            ex.Executar();
        }
    }

    public class Ex1868
    {
        StringBuilder linhaComO;

        public void Executar()
        {
            var n = 0;
            while ((n = int.Parse(Console.ReadLine())) != 0)
            {
                CriarMatriz(n);
            }
        }

        private void CriarMatriz(int n)
        {
            int[,] matriz = new int[n, n];

            var coordenada = new Coordenada(n / 2, n / 2);

            List<Direcao> direcoes = new List<Direcao>();
            direcoes.Add(new Direita());
            direcoes.Add(new Cima());
            direcoes.Add(new Esquerda());
            direcoes.Add(new Baixo());

            var direcao = 0;

            var tamanhoDoPasso = 1;
            var passos = 0;
            var vezesPasso = 0;
            var limite = n * n;
            linhaComO = new StringBuilder().Append('O', n);

            for (int i = 0; i < limite; i++)
            {
                ImprimirMatriz(n, coordenada.X, coordenada.Y);

                if (passos < tamanhoDoPasso)
                {
                    var d = direcao % 4;
                    coordenada = direcoes[d].Andar(coordenada.X, coordenada.Y);

                    passos++;
                    if (passos == tamanhoDoPasso)
                    {
                        direcao++;
                        passos = 0;
                        vezesPasso++;
                        if (vezesPasso == 2)
                        {
                            tamanhoDoPasso++;
                            vezesPasso = 0;
                        }
                    }
                }
            }
        }


        private void ImprimirMatriz(int n, int x, int y)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == x)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (x != i || y != j)
                            Console.Write("O");
                        else
                            Console.Write("X");
                    }
                }
                else
                {
                    Console.Write("{0}", linhaComO);
                }

                Console.Write("\n");
            }
            Console.Write("@\n");
        }
    }
    public struct Coordenada
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public abstract class Direcao
    {
        public virtual Coordenada Andar(int i, int j)
        {
            throw new NotImplementedException();
        }
    }

    public class Direita : Direcao
    {
        public override Coordenada Andar(int i, int j)
        {
            return new Coordenada(i, ++j);
        }
    }

    public class Cima : Direcao
    {
        public override Coordenada Andar(int i, int j)
        {
            return new Coordenada(--i, j);
        }
    }

    public class Esquerda : Direcao
    {
        public override Coordenada Andar(int i, int j)
        {
            return new Coordenada(i, --j);
        }
    }

    public class Baixo : Direcao
    {
        public override Coordenada Andar(int i, int j)
        {
            return new Coordenada(++i, j);
        }
    }
}
