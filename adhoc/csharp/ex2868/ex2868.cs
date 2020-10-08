using System;

class URI
{
    static void Main(string[] args)
    {
        var casos = Int32.Parse(Console.ReadLine());

        while(casos-- > 0)
        {
            var entradas = Console.ReadLine();

            var n1 = Int32.Parse(entradas.Split(' ')[0]);
            var n2 = Int32.Parse(entradas.Split(' ')[2]);
            var op = entradas.Split(' ')[1];
            var resposta = Int32.Parse(entradas.Split(' ')[4]);
            var resultado = 0;

            if(op == "+")
                resultado = n1 + n2;
            else if(op == "x")
                resultado = n1 * n2;
            else if(op == "-")
                resultado = n1 -n2;

            var erres = Math.Abs(resposta - resultado);

            var saida = "E";

            for(int i= 0; i < erres; i++)
                saida += "r";

            saida += "ou!";

            Console.Write("{0}\n", saida);
        }
    }
}