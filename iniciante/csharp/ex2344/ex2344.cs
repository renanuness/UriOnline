using System;

class URI
{
    static void Main(string[] args)
    {
        var nota = Int32.Parse(Console.ReadLine());

        char conceito = 'E';
        
        if(nota >= 1 && nota <= 35)
            conceito = 'D';
        else if(nota >= 36 && nota <= 60)
            conceito = 'C';
        else if(nota >= 61 && nota <= 85)
            conceito = 'B';
        else if(nota >= 86 && nota <= 100)
            conceito = 'A';
    
        Console.Write("{0}\n", conceito);
    }
}