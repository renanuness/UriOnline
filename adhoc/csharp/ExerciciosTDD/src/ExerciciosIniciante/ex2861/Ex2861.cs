using System;

namespace ExerciciosIniciante.ex2861
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2861();
            ex.Executar();
        }
    }

    public class Ex2861
    {
        public void Executar()
        {
            var casosDeTeste = LerCasosDeTeste();

            for (int i = 0; i < casosDeTeste; i++)
            {
                LerLinha();
                Console.Write("gzuz\n");
            }
        }

        public int LerCasosDeTeste()
        {
            return int.Parse(LerLinha());
        }

        public string LerLinha()
        {
            return Console.ReadLine();
        }
    }
}
