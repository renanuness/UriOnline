using System;

class URI
{
    static void Main(string[] args)
    {
        while(true)
        {
            var entradas = Console.ReadLine();
            var n1 = Int32.Parse(entradas.Split(' ')[0]);
            var n2 = Int32.Parse(entradas.Split(' ')[1]);

            if(n1 + n2 == 0)
                break;
                
            var mediaAproximada = ((double) n1 + (double) n2)/3; 

            var mediaInt = Math.Ceiling(mediaAproximada);
            
            var mediana = mediaInt * 3 - n1 - n2; 
            Console.Write("{0}\n", mediana);

        }
    }
}