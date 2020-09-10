using System;

class URI
{
    static void Main(string[] args)
    {
        var idadeEmDias = Int32.Parse(Console.ReadLine());

        var anos = idadeEmDias / 365;
        idadeEmDias = idadeEmDias % 365;

        var meses = idadeEmDias / 30;
        idadeEmDias = idadeEmDias % 30;

        Console.Write("{0} ano(s)\n",anos);
        Console.Write("{0} mes(es)\n",meses);
        Console.Write("{0} dia(s)\n",idadeEmDias);
        
    }
}