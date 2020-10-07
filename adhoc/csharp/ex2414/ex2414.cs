using System;

class URI
{
    static void Main(string[] args)
    {
        var entradas = Console.ReadLine();

        var maiorValor = 0;
        int valores = 0;
        while(true)
        {
            var valor = Int32.Parse(entradas.Split(' ')[valores]);
            if(valor == 0)
                break;
            
            if(valor > maiorValor)
                maiorValor = valor;

            valores++;
        }

        Console.Write("{0}\n", maiorValor);
    }
}

