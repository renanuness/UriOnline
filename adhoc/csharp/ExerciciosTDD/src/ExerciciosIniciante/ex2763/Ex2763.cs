using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.ex2763
{
    public class URI
    {
        static void Main(string[] args)
        {
            var entrada = Console.ReadLine();

            for(int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] == '.' || entrada[i] == '-')
                    Console.Write("\n");
                else
                    Console.Write("{0}", entrada[i]);
            }
            Console.Write("\n");
        }
    }
}
