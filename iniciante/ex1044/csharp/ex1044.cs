using System;

class URI
{
    static void Main(string[] args)
    {
        string valores = Console.ReadLine();

        int a = Int32.Parse(valores.Split(' ')[0]);
        int b = Int32.Parse(valores.Split(' ')[1]);
    
        if(b % a == 0 ) Console.Write("Sao Multiplos\n");
        else if(a % b == 0 ) Console.Write("Sao Multiplos\n");
        else Console.Write("Nao sao Multiplos\n");
    }
}