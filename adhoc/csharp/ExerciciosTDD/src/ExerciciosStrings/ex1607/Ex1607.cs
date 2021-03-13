using System;

namespace ExerciciosStrings.Exercicio1607
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1607();
            ex.Executar();
        }
    }

    public class Ex1607
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while (casos-- > 0)
            {
                var entrada = LerLinha().Split(' ');

                var atual = entrada[0];
                var objetivo = entrada[1];
                var contador = 0;

                for (int i = 0; i < atual.Length; i++)
                {
                    var l = atual[i];
                    while (true)
                    {
                        if (l != objetivo[i])
                        {
                            l++;
                            contador++;
                            if (l == 123)
                                l = (char)97;
                        }
                        else
                            break;
                    }
                }
                Console.Write("{0}\n", contador);
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
    }
}
