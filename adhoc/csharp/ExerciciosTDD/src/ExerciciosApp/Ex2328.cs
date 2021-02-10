using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosAdHoc.ex2328
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2328();
            ex.Executar();
        }
        
    }

    public class Ex2328
    {
        public int _casosDeTeste { get; private set; }
        public List<int> _valores { get; private set; }

        public void Executar()
        {
            _valores = new List<int>();
            LerCasosDeTeste();

            LerInteiros();
                
            Console.Write("{0}\n", _valores.Sum());
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }
        public void LerCasosDeTeste()
        {
            _casosDeTeste = int.Parse(LerLinha());
        }

        public void LerInteiros()
        {
            var linha = LerLinha();

            var iteracoes = _casosDeTeste;

            
            while (iteracoes-- > 0)
            {
                var valor = int.Parse(linha.Split(' ')[iteracoes]);
                _valores.Add(valor - 1);
            }
        }
    }
}
