using System;

class URI
{
    static void Main(string[] args)
    {
        var quantidade = Int32.Parse(Console.ReadLine());

        var coposQuebrados = 0;
        while(quantidade-- > 0)
        {
            var entradas = Console.ReadLine();

            var latas = Int32.Parse(entradas.Split(' ')[0]);
            var copos = Int32.Parse(entradas.Split(' ')[1]);
        
            if(latas > copos)
                coposQuebrados += copos;
        }

        Console.Write("{0}\n", coposQuebrados);
    }
}