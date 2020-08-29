using System;

class URI
{
    static void Main(string[] args)
    {
        string ossatura = Console.ReadLine();
        string classe = Console.ReadLine();
        string alimentacao = Console.ReadLine();

        if(ossatura == "vertebrado")
        {
            if(classe == "ave")
            {
                if(alimentacao == "carnivoro")
                {
                    Console.Write("aguia\n");
                }
                else
                {
                    Console.Write("pomba\n");
                }
            }
            else
            {
                if(alimentacao == "onivoro")
                {
                    Console.Write("homem\n");
                }
                else
                {
                    Console.Write("vaca\n");
                }
            }
        }
        else
        {
            if(classe == "inseto")
            {
                if(alimentacao == "hematofago")
                {
                    Console.Write("pulga\n");
                }
                else
                {
                    Console.Write("lagarta\n");
                }
            }
            else
            {
                if(alimentacao == "hematofago")
                {
                    Console.Write("sanguessuga\n");
                }
                else
                {
                    Console.Write("minhoca\n");
                }
            }
        }
    }
}