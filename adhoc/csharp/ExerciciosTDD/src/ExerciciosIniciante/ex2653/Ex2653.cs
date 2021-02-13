using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosIniciante.Exercicio2653
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2653();
        }
    }

    public class Ex2653
    {
        List<string> _joias;

        public Ex2653()
        {
            _joias = new List<string>();
            LerJoias();
            Contagem();
        }

        private void LerJoias()
        {
            var joia = "";
            while (!string.IsNullOrEmpty(joia = LerLinha()))
            {
                if (!_joias.Any(x => x == joia))
                    _joias.Add(joia);
            }
        }

        public void Contagem()
        {
            Console.Write("{0}\n", _joias.Count);
        }
        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }
}
