using System;

namespace ExerciciosStrings.Exercicio2714
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2714();
            ex.Executar();
        }
    }

    public class Ex2714
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while (casos-- > 0)
            {
                var linha = LerLinha();

                bool valida = true;

                if (!linha.StartsWith("RA"))
                    valida = false;
                if (linha.Length != 20)
                    valida = false;

                if (!valida)
                {
                    PrintInvalido();
                    continue;
                }

                linha = linha.Remove(0, 2);
                Int64 valor;
                if (Int64.TryParse(linha, out valor))
                {
                    Console.Write("{0}\n", valor);
                }
                else
                    PrintInvalido();
            }
        }

        private void PrintInvalido()
        {
            Console.Write("INVALID DATA\n");
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
