using System;

class URI
{
    static void Main(string[] args)
    {
        while(true)
        {
            var entradas = Console.ReadLine();

            var a = Int32.Parse(entradas.Split(' ')[0]);
            var b = Int32.Parse(entradas.Split(' ')[1]);
            var c = Int32.Parse(entradas.Split(' ')[2]);
        
            if(a == 0 && a == b && b == c)
                break;

            var volume = a * b * c;

            var arestaCubo = (int)Math.Pow(volume, (1.0 / 3.0));
            Console.Write("{0}\n", arestaCubo);
        }
    }
}