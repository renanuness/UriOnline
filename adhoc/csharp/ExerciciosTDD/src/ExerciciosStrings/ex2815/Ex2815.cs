using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosStrings.Exercicio2815
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2815();
            ex.Executar();
        }
    }

    public class Ex2815
    {
        public void Executar()
        {
            var entrada = Console.ReadLine();

            var sb = new StringBuilder();
            var ignorarProxima = false;
            var ultima = 0;
            for (int i = 0; i < entrada.Length - 3; i++)
            {
                var silaba = entrada.Substring(i, 2);
                if (silaba != entrada.Substring(i + 2, 2))
                {
                    if (ignorarProxima)
                        ignorarProxima = false;
                    else
                        sb.Append(entrada[i]);

                }
                else
                {
                    ignorarProxima = true;
                }
                ultima = i+1;
            }
            sb.Append(entrada.Substring(ultima));
            Console.Write("{0}\n", sb.ToString());
        }
    }
}
