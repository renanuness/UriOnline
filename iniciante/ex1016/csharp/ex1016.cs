using System;

class URI
{
    static void Main(string[] args)
    {
        const int HORA_EM_MINUTOS = 60;
        const int VELOCIDADE_CARRO_A = 60;
        const int VELOCIDADE_CARRO_B = 90;

        var distancia = Int32.Parse(Console.ReadLine());

        var tempoMinutos = (distancia * HORA_EM_MINUTOS)/(VELOCIDADE_CARRO_B - VELOCIDADE_CARRO_A);

        Console.Write("{0} minutos\n", tempoMinutos);
    }
}