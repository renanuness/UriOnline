using System;

class URI
{
    static void Main(string[] args)
    {
        var valores = Console.ReadLine();

        var comecoHora = Int32.Parse(valores.Split(' ')[0]);
        var comecoMinutos = Int32.Parse(valores.Split(' ')[1]);
        var finalHora = Int32.Parse(valores.Split(' ')[2]);
        var finalMinutos = Int32.Parse(valores.Split(' ')[3]);

        if(finalHora <= comecoHora && finalMinutos <= comecoMinutos)
            finalHora += 24;
        
        if(finalMinutos <= comecoMinutos)
        {
            finalMinutos += 60;
            finalHora--;
        }

        var duracaoHoras = finalHora - comecoHora;
        var duracaoMinutos = finalMinutos - comecoMinutos;

        if(duracaoMinutos >= 60)
        {
            duracaoMinutos -= 60;
            duracaoHoras++;
        }
        Console.Write("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)\n", duracaoHoras, duracaoMinutos);
    }
}