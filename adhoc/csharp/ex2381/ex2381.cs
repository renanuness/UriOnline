using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Console.ReadLine();

        var numeroAlunos = Int32.Parse(entradas.Split(' ')[0]);
        var alunoSorteado = Int32.Parse(entradas.Split(' ')[1]);

        List<string> alunos = new List<string>();
        while(numeroAlunos-- > 0)
            alunos.Add(Console.ReadLine());

        alunos.Sort();

        Console.Write("{0}\n", alunos[alunoSorteado-1]);
    }
}