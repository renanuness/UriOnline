using System;

class URI
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();

        var copos = new int[4];

        copos[0] = Int32.Parse(entrada.Split(' ')[0]);
        copos[1] = Int32.Parse(entrada.Split(' ')[1]);
        copos[2] = Int32.Parse(entrada.Split(' ')[2]);
        copos[3] = Int32.Parse(entrada.Split(' ')[3]);

        for(int i = 0; i < 4; i++)
        {
            if(copos[i] == 1)
                Console.Write("{0}\n", i+1);
        }
    }
}