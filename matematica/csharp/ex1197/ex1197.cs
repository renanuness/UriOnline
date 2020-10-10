using System;

class URI
{
    static void Main(string[] args)
    {
        while(true)
        {
            var entradas = LerEntrada();

            if(string.IsNullOrEmpty(entradas))
                break;

            var v = Int32.Parse(entradas.Split(' ')[0]);
            var t = Int32.Parse(entradas.Split(' ')[1]);

            var resultado =  t*2 * v;
            Console.Write("{0}\n", resultado);
        }
    }

    public static string LerEntrada()
    {
        return Console.ReadLine();
    }
}