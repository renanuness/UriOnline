using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        Dictionary<int, string> ddds = new Dictionary<int, string>();
        ddds.Add(61, "Brasilia");
        ddds.Add(71, "Salvador");
        ddds.Add(11, "Sao Paulo");
        ddds.Add(21, "Rio de Janeiro");
        ddds.Add(32, "Juiz de Fora");
        ddds.Add(19, "Campinas");
        ddds.Add(27, "Vitoria");
        ddds.Add(31, "Belo Horizonte");

        var entrada = Int32.Parse(Console.ReadLine());

        string estado;

        if(ddds.TryGetValue(entrada, out estado))
        {
            Console.Write("{0}\n", estado);
            return;
        }
        Console.Write("DDD nao cadastrado\n");
    }
}