using System;

class URI
{
    static void Main(string[] args)
    {
        var casosDeTeste = Int32.Parse(Console.ReadLine());
        
        while(casosDeTeste-- > 0)
        {
            var entradas = Console.ReadLine();

            var x = double.Parse(entradas.Split(' ')[0]);
            var y = double.Parse(entradas.Split(' ')[1]);

            x -= 2;
            y -= 2;
            
            var sonaresVertical = x / 3;
            var sonaresHorizontal = y / 3;
            
            sonaresVertical = Math.Ceiling(sonaresVertical);
            sonaresHorizontal = Math.Ceiling(sonaresHorizontal);

            Console.Write("{0}\n", sonaresHorizontal * sonaresVertical);
        }
    }

}