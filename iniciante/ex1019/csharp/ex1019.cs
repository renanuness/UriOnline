using System;

class URI
{
    static void Main(string[] args)
    {
        var tempoEmSegundos = Int32.Parse(Console.ReadLine());

        var horas = tempoEmSegundos / 3600;
        tempoEmSegundos = tempoEmSegundos % 3600;

        var minutos = tempoEmSegundos / 60;
        tempoEmSegundos = tempoEmSegundos % 60;

        Console.Write("{0}:{1}:{2}\n", horas, minutos, tempoEmSegundos); 
    }
}