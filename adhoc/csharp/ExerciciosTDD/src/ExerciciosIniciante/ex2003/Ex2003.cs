using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.Exercicio2003
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2003();
            ex.Executar();
        }
    }

    public class Ex2003
    {
        public void Executar()
        {
            var entrada = "";
            while (!string.IsNullOrEmpty(entrada = LerLinha()))
            {
                var horario = entrada.Split(':');
                var hora = int.Parse(horario[0]);
                var minutos = int.Parse(horario[1]);

                var atrasoMaximo = 0;

                if (hora >= 7)
                {
                    hora++;
                    atrasoMaximo = (hora * 60 + minutos) - (480);
                }
                Imprimir(atrasoMaximo);
            }
        }

        private void Imprimir(int atrasoMaximo)
        {
            Console.Write("Atraso Maximo: {0}\n", atrasoMaximo);

        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }
}
