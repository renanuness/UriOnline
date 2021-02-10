using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ExerciciosParadigmas.ex1608
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1608();
            ex.Executar();
        }
    }

    public class Ex1608
    {
        public int CasosDeTeste { get; private set; }
        public int NumeroDeIngredientes { get; private set; }
        public int NumeroDeBolos { get; private set; }
        public int DinheiroDisponivel { get; private set; }
        public List<Ingrediente> Ingredientes { get; private set; }
        public Bolo BoloMaisBarato { get; private set; }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        public int LerCasosDeTeste()
        {
            return int.Parse(LerLinha());
        }

        public void Executar()
        {
            CasosDeTeste = LerCasosDeTeste();

            while (CasosDeTeste-- > 0)
            {
                Ingredientes = new List<Ingrediente>();
                Core();
            }
        }

        private void Core()
        {
            BoloMaisBarato = new Bolo();
            BoloMaisBarato.DefinirValorMaximoBolo();

            LerDinheiroIngredienteBolos();
            LerIngredientes();
            LerBolos();
            CalcularQuantidadeBolos();
        }

        private void LerDinheiroIngredienteBolos()
        {
            var entradas = LerMultiplasEntradas(3);
            DinheiroDisponivel = entradas[0];
            NumeroDeIngredientes = entradas[1];
            NumeroDeBolos = entradas[2];
        }

        private void LerIngredientes()
        {
            var valores = LerMultiplasEntradas(NumeroDeIngredientes);

            for (int i = 0; i < NumeroDeIngredientes; i++)
                Ingredientes.Add(new Ingrediente(i, valores[i]));
        }

        private void LerBolos()
        {
            for (int i = 0; i < NumeroDeBolos; i++)
            {
                LerBolo();
            }
        }

        private void LerBolo()
        {
            var entrada = LerLinha();

            var entradaArray = entrada.Split(' ');
            var numeroDeIngredientes = int.Parse(entradaArray[0]);
            var iteracoesParaLerIngredientes = numeroDeIngredientes * 2 + 1;

            var bolo = new Bolo();
            for (int i = 1; i < iteracoesParaLerIngredientes; i += 2)
            {
                var ingredienteId = int.Parse(entradaArray[i]);
                var ingredienteQuantidade = int.Parse(entradaArray[i + 1]);

                var ingrediente = Ingredientes[ingredienteId];
                var ingredienteBolo = new IngredienteBolo(ingrediente, ingredienteQuantidade);

                ingredienteBolo.CalcularValor();

                bolo.AdicionarIngrediente(ingredienteBolo);
            }
            
            bolo.DefinirQuantidadeBolos(DinheiroDisponivel);

            if (bolo.QuantidadeBolos > BoloMaisBarato.QuantidadeBolos)
                BoloMaisBarato = bolo;
        }

        private void CalcularQuantidadeBolos()
        {
            Console.Write("{0}\n", BoloMaisBarato.QuantidadeBolos);
        }

        private int[] LerMultiplasEntradas(int entradas)
        {
            var entrada = LerLinha();

            int[] valores = new int[entradas];
            string[] entradaArray = entrada.Split(' ');
            
            for (int i = 0; i < entradas; i++)
                valores[i] = int.Parse(entradaArray[i]);

            return valores;
        }

    }

    public class Bolo
    {
        private List<IngredienteBolo> _ingredientes;
        public IReadOnlyCollection<IngredienteBolo> Ingredientes => _ingredientes;

        public void AdicionarIngrediente(IngredienteBolo ingrediente)
        {
            if (_ingredientes == null)
                _ingredientes = new List<IngredienteBolo>();

            _ingredientes.Add(ingrediente);
            CalcularValorTotal();
        }
        public int ValorBolo { get; private set; }
        public int QuantidadeBolos { get; private set; }

        public void CalcularValorTotal()
        {
            ValorBolo = _ingredientes.Sum(t => t.ValorTotalIngrediente);
        }

        public void DefinirQuantidadeBolos(int dinheiroDisponivel)
        {
            QuantidadeBolos = dinheiroDisponivel / ValorBolo;
        }

        public void DefinirValorMaximoBolo()
        {
            QuantidadeBolos = 0;
            ValorBolo = 9999;
        }
    }

    public class IngredienteBolo
    {
        public Ingrediente Ingrediente { get; private set; }
        public int Quantidade { get; private set; }

        public IngredienteBolo(Ingrediente ingrediente, int quantidade)
        {
            Ingrediente = ingrediente;
            Quantidade = quantidade;
        }

        public int ValorTotalIngrediente { get; private set; }

        public void CalcularValor()
        {
            ValorTotalIngrediente = Ingrediente.Valor * Quantidade;
        }
    }

    public class Ingrediente
    {
        public int Id { get; private set; }
        public int Valor { get; private set; }

        public Ingrediente(int id, int valor)
        {
            Id = id;
            Valor = valor;
        }
    }
}
