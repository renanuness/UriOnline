using System;

class URI
{
    static void Main(string[] args)
    {
        var numeroCandidatos = Int32.Parse(Console.ReadLine());
        var entradas = Console.ReadLine();
        
        var contagem = 0;
        while(numeroCandidatos-- > 0)
        {
            var valor = Int32.Parse(entradas.Split(' ')[numeroCandidatos]);
            if(valor == 1)
                contagem++;
        }

        Console.Write("{0}\n", contagem);
    }
}