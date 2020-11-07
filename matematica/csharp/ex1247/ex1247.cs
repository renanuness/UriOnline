using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        List<bool> resultados = new List<bool>();

        while(true)
        {
            var entradas = LerEntrada();

            if(string.IsNullOrEmpty(entradas))
                break;

            var d = double.Parse(entradas.Split(' ')[0]);
            var vf = double.Parse(entradas.Split(' ')[1]);
            var vg = double.Parse(entradas.Split(' ')[2]);

            var vaiCapturar = false;

            if(vf > vg)
            {
                vaiCapturar = false;
                resultados.Add(vaiCapturar);
                continue;
            }
            
            var somaDosCatetos = 144 + (d*d);
            var distanciaG = Math.Sqrt(somaDosCatetos);
            //v = d/t
            //t = d/v
            //9 12 15
            var tf = 12 / vf;
            var tg = distanciaG / vg;

            // Console.Write("{0}\n", somaDosCatetos);
            // Console.Write("{0}\n", distanciaG);
            // Console.Write("{0}\n", tg);

            if(tf < tg)
                vaiCapturar = false;
            else
                vaiCapturar = true;

            resultados.Add(vaiCapturar);
        }
        resultados.ForEach(r=> Imprimir(r));
    }

    public static string LerEntrada()
    {
        return Console.ReadLine();
    }

    public static void Imprimir(bool vaiCapturar)
    {
        var s = vaiCapturar ? "S" : "N";

        Console.Write("{0}\n", s);
    }
}