using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ExerciciosIniciante.Exercicio2311
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2311();
            ex.Executar();
        }
    }

    public class Ex2311
    {
        public void Executar()
        {
            List<Aluno> alunos = new List<Aluno>();
            var numeroDeAlunos = LerInteiro();

            while(numeroDeAlunos-- > 0)
            {
                var nome = LerLinha();
                var grauDeDificuldade = LerInteiro();
                var notas = LerMultiplasEntradas(7);
                alunos.Add(new Aluno(nome, notas.ToList(), grauDeDificuldade));
            }

            alunos.ForEach(x => x.CalcularNota());
            alunos.ForEach(x => x.Imprimir());
        }

        private double LerInteiro()
        {
            return double.Parse(LerLinha(), CultureInfo.InvariantCulture);
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        private double[] LerMultiplasEntradas(int entradas)
        {
            var entrada = LerLinha();

            if (string.IsNullOrEmpty(entrada))
                return null;

            double[] valores = new double[entradas];
            var entradaArray = entrada.Split(' ');
            for (int i = 0; i < entradas; i++)
            {
                valores[i] = double.Parse(entradaArray[i], CultureInfo.InvariantCulture);
            }

            return valores;
        }
    }

    public class Aluno
    {
        public double GrauDeDificuldade { get; private set; }
        public List<double> Saltos { get; private set; }
        public string Nome { get; set; }
        public double Nota { get; set; }

        public Aluno(string nome, List<double> saltos, double grauDeDificuldade)
        {
            Nome = nome;
            Saltos = saltos;
            GrauDeDificuldade = grauDeDificuldade;
        }

        public void CalcularNota()
        {
            Saltos = Saltos.OrderByDescending(x => x).ToList();

            var maior = Saltos[0];
            var menor = Saltos[Saltos.Count - 1];

            Saltos.RemoveAt(0);
            Saltos.RemoveAt(Saltos.Count - 1);

            Nota = Saltos.Sum() * GrauDeDificuldade;

            Saltos.Add(maior);
            Saltos.Add(menor);
        }

        public void Imprimir()
        {
            Console.Write("{0} {1:f2}\n", Nome, Nota);
        }
    }
}
