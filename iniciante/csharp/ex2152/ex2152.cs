using System;

class URI
{
    static void Main(string[] args)
    {
        int entradas = Int32.Parse(Console.ReadLine());

        while(entradas-- > 0)
        {
            string valores = Console.ReadLine();

            var horas = (valores.Split(' ')[0]);
            var minutos = (valores.Split(' ')[1]);
            var acao = Int32.Parse(valores.Split(' ')[2]);
        
            string acaoStr = acao == 1 ? "A porta abriu!" : "A porta fechou!";
            Console.Write("{0}:{1} - {2}\n", horas.PadLeft(2, '0'), minutos.PadLeft(2, '0'), acaoStr);
        }
    }
}