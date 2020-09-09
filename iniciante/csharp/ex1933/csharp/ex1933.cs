using System;

class URI
{
    static void Main(string[] args)
    {
        string cartas = Console.ReadLine();

        var cartaUm = Int32.Parse(cartas.Split(' ')[0]);
        var cartaDois = Int32.Parse(cartas.Split(' ')[1]);
        
        var cartaTres = 0;
        if(cartaUm == cartaDois)
            cartaTres = cartaUm;
        else
            cartaTres = cartaUm > cartaDois ? cartaUm : cartaDois;

        Console.Write("{0}\n", cartaTres);
    }
}