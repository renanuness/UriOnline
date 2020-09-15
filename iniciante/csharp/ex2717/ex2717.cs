using System;

class URI
{
    static void Main(string[] args)
    {
        int minutosRestantes = Int32.Parse(Console.ReadLine());
        
        string minutosString = Console.ReadLine();
        int minutos1 = Int32.Parse(minutosString.Split(' ')[0]);
        int minutos2 = Int32.Parse(minutosString.Split(' ')[1]);

        if(minutos1 + minutos2 <= minutosRestantes)
        {
            Console.Write("Farei hoje!\n");
        }else
        {
            Console.Write("Deixa para amanha!\n");
        }
    }
}