using System;

class URI
{
    static void Main(string[] args)
    {
        int casosDeTeste = Int32.Parse(Console.ReadLine());
        int[] resultados = new int[casosDeTeste];

        for(int i = 0; i < casosDeTeste; i++)
        {
            string valores = Console.ReadLine();
            var K = Int32.Parse(valores.Split(' ')[0]);
            var N = Int32.Parse(valores.Split(' ')[1]);

            var resto = K % N;
            var divisao = K / N;
            resultados[i] = resto + divisao;
        }

        for(int i = 0; i < casosDeTeste; i++)
        {
            Console.Write("{0}\n", resultados[i]);
        }
    }
}