using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosStrings.Exercicio1873
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1873();
            ex.Executar();
        }
    }

    public class Ex1873
    {
        private List<Arma> armas;

        private void InicializarLista()
        {
            armas = new List<Arma>();

            var spock = new Arma("spock");
            var pedra = new Arma("pedra");
            var papel = new Arma("papel");
            var tesoura = new Arma("tesoura");
            var lagarto = new Arma("lagarto");

            spock.AddGanha(tesoura);
            spock.AddGanha(pedra);

            tesoura.AddGanha(papel);
            tesoura.AddGanha(lagarto);

            pedra.AddGanha(tesoura);
            pedra.AddGanha(lagarto);

            papel.AddGanha(pedra);
            papel.AddGanha(spock);

            lagarto.AddGanha(spock);
            lagarto.AddGanha(papel);

            armas.Add(spock);
            armas.Add(tesoura);
            armas.Add(pedra);
            armas.Add(papel);
            armas.Add(lagarto);

        }
        public void Executar()
        {
            InicializarLista();
            var partidas = LerInteiro();
            while(partidas-- > 0)
            {
                var entradas = LerLinha().Split(' ');

                var rajesh = armas.First(x => x.Nome == entradas[0]);
                var sheldon = armas.First(x => x.Nome ==entradas[1]);

                ImprimirResultado(sheldon, rajesh);
            }
        }

        public void ImprimirResultado(Arma sheldon, Arma rajesh)
        {
            if (sheldon.Nome == rajesh.Nome)
            { Console.Write("empate\n"); }

            if (sheldon.Ganha.Contains(rajesh))
                Console.Write("sheldon\n");
            else if (rajesh.Ganha.Contains(sheldon))
                Console.Write("rajesh\n");

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

    public class Arma
    {
        public string Nome { get; private set; }

        public List<Arma> Ganha { get; private set; }

        public Arma(string nome)
        {
            Nome = nome;
            Ganha = new List<Arma>();
        }

        public void AddGanha(Arma arma)
        {
            Ganha.Add(arma);
        }
    }
}
