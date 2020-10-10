using System;

class URI
{
    static void Main(string[] args)
    {
        var casosDeTeste = Int32.Parse(Console.ReadLine());

        for(int i = 1; i <= casosDeTeste; i++)
        {
            var entradas = Console.ReadLine();

            var n = Int32.Parse(entradas.Split(' ')[0]);

            var index = ((n-1)/2)+1;

            var idadeCapitao = Int32.Parse(entradas.Split(' ')[index]);

            Console.Write("Case {0}: {1}\n", i, idadeCapitao);
        }
    }
}