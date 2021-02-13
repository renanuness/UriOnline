using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio1960
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1960();
            ex.Executar();
        }
    }

    public class Ex1960
    {
        public void Executar()
        {
            var valor = LerInteiro();
            var valorRomano = Converter(valor);
            Console.Write("{0}\n", valorRomano);
        }

        public string Converter(int valor)
        {
            StringBuilder valorRomano = new StringBuilder();

            if (valor / 900 == 1)
            {
                valorRomano.Append("CM");
                valor -= 900;
            }
            if (valor / 500 == 1)
            {
                valorRomano.Append("D");
                valor -= 500;
            }
            if (valor / 400 == 1)
            {
                valorRomano.Append("CD");
                valor -= 400;
            }
            if (valor / 100 == 3)
            {
                valorRomano.Append("CCC");
                valor -= 300;
            }
            if (valor / 100 == 2)
            {
                valorRomano.Append("CC");
                valor -= 200;
            }
            if (valor / 100 == 1)
            {
                valorRomano.Append("C");
                valor -= 100;
            }
            if (valor / 90 == 1)
            {
                valorRomano.Append("XC");
                valor -= 90;
            }
            if (valor / 50 == 1)
            {
                valorRomano.Append("L");
                valor -= 50;
            }
            if (valor / 40 == 1)
            {
                valorRomano.Append("XL");
                valor -= 40;
            }
            if (valor / 10 == 3)
            {
                valorRomano.Append("XXX");
                valor -= 30;
            }
            if (valor / 10 == 2)
            {
                valorRomano.Append("XX");
                valor -= 20;
            }
            if (valor / 10 == 1)
            {
                valorRomano.Append("X");
                valor -= 10;
            }
            if (valor / 9 == 1)
            {
                valorRomano.Append("IX");
                valor -= 9;
            }
            if(valor / 5 == 1)
            {
                valorRomano.Append("V");
                valor -= 5;
            }
            if(valor / 4 == 1)
            {
                valorRomano.Append("IV");
                valor -= 4;
            }
            if(valor / 1 == 3)
            {
                valorRomano.Append("III");
                valor -= 3;
            }
            if (valor / 1 == 2)
            {
                valorRomano.Append("II");
                valor -= 2;
            }
            if (valor / 1 == 1)
            {
                valorRomano.Append("I");
                valor -= 1;
            }

            return valorRomano.ToString();
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
}
