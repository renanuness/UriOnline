using System;

class URI
{
    static void Main(string[] args)
    {
        var casosDeTeste = Int32.Parse(Console.ReadLine());

        while(casosDeTeste-- > 0)
        {
            var linhas = Int32.Parse(Console.ReadLine());

            var resultado = Math.Pow(2, linhas) - 1;

            Console.Write("{0}\n", resultado);
        }
    }
}