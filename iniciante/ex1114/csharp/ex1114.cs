using System;

class URI
{
    static void Main(string[] args)
    {
        var senha = Int32.Parse(Console.ReadLine());
        while(senha != 2002)
        {
            Console.Write("Senha Invalida\n");
            senha = Int32.Parse(Console.ReadLine());
        }
        Console.Write("Acesso Permitido\n");
    }
}