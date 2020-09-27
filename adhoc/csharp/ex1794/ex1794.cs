using System;

class URI
{
    static void Main(string[] args)
    {
        var numeroRoupas = Int32.Parse(Console.ReadLine());
        
        var limitesLavadora = Console.ReadLine();
        var la = Int32.Parse(limitesLavadora.Split(' ')[0]);
        var lb = Int32.Parse(limitesLavadora.Split(' ')[1]);
        
        var limitesSecadora = Console.ReadLine();
        var sa = Int32.Parse(limitesSecadora.Split(' ')[0]);
        var sb = Int32.Parse(limitesSecadora.Split(' ')[1]);

        string resultado = "possivel";
        if(numeroRoupas < la || numeroRoupas < sa)
            resultado = "impossivel";
        if(numeroRoupas > lb || numeroRoupas > sb)
            resultado = "impossivel";

        Console.Write("{0}\n", resultado);
    }
}