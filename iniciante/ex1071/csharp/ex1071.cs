using System;

class URI
{
    static void Main(string[] args)
    {
        int comeco = Int32.Parse(Console.ReadLine());
        int final = Int32.Parse(Console.ReadLine());

        if(comeco > final)
        {
            int temp = comeco;
            comeco = final;
            final = temp;
        }

        int somaImpares = 0;
        int cursor= comeco +1;
        
        while (cursor < final)
        {
            if(cursor % 2 != 0)
                somaImpares += cursor;
                
            cursor++;
        }

        Console.Write("{0}\n", somaImpares);
    }
}