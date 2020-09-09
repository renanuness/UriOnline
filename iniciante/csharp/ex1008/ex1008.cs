using System;

class Uri
{
    static void Main(string[] args)
    {
        var funcionarioId = Int32.Parse(Console.ReadLine());
        var numeroHoras = Int32.Parse(Console.ReadLine());
        var salarioPorHora = Double.Parse(Console.ReadLine());

        double salario = (double)numeroHoras * salarioPorHora;

        Console.Write("NUMBER = {0}\n", funcionarioId);
        Console.Write("SALARY = U$ {0:f2}\n", salario);
    }       
}