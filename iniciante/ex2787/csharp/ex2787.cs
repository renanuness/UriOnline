using System;

class URI
{
    static void Main(string[] args)
    {
        var linha = Int32.Parse(Console.ReadLine());
        var coluna = Int32.Parse(Console.ReadLine());

        var cor = 0;
        if(linha % 2 == 0)
        {
            if(coluna % 2 == 0)
            {
                cor = 1;
            }
            else
            {
                cor = 0;
            }
        }
        else
        {
            if(coluna % 2 == 0)
            {
                cor = 0;
            }
            else
            {
                cor = 1;
            }
        }
        Console.Write("{0}\n", cor);
    }
}