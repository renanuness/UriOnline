using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.ex2862
{
    public class URI
    {
        static void Main(string[] args)
        {
            var entradas = int.Parse(Console.ReadLine());

            while(entradas-- > 0)
            {
                var energia = int.Parse(Console.ReadLine());

                if (energia > 8000)
                    Console.Write("Mais de 8000!\n");
                else
                    Console.Write("Inseto!\n");
            }
        }
    }
}
