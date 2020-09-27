using System;

class URI
{
    static void Main(string[] args)
    {
        var casosDeTeste = Int32.Parse(Console.ReadLine());
        while(casosDeTeste-- > 0)
        {
            var feedbacks = Int32.Parse(Console.ReadLine());
            while(feedbacks-- > 0)
            {
                var setor = Int32.Parse(Console.ReadLine());
                switch (setor)
                {
                    case 1 :
                        Console.Write("Rolien\n");
                        break;
                    case 2 :
                        Console.Write("Naej\n");
                        break;
                    case 3 :
                        Console.Write("Elechim\n");
                        break;
                    case 4 :
                        Console.Write("Odranoel\n");
                        break;
                }
            }
        }
    }
}