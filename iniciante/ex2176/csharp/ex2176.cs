using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        string mensagem = Console.ReadLine();

        int bits1 =  mensagem.Count(x => x == '1');

        mensagem = (bits1 % 2 == 0) ? string.Concat(mensagem, '0') : string.Concat(mensagem, '1');

        Console.Write("{0}\n", mensagem);
    }
}