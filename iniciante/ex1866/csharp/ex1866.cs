using System;

class URI
{
    static void Main(string[] args)
    {
        int termos = Int32.Parse(Console.ReadLine());

        while(termos-- > 0)
        {
            int valor = Int32.Parse(Console.ReadLine());

            var resultado = valor % 2 == 0 ? 0 : 1;

            Console.Write("{0}\n", resultado);
        }
    }
}