using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.ex2483
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2483();
            ex.Executar();
        }
    }
    
    public class Ex2483
    {
        public void Executar()
        {
            var entrada = int.Parse(Console.ReadLine()); 
            StringBuilder sb = new StringBuilder();
            sb.Append("Feliz nat");
            sb.Append('a', entrada);
            sb.Append("l!");

            Console.Write("{0}\n", sb.ToString());
        }
    }
}
