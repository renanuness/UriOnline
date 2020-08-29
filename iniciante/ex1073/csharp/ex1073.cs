using System;

class URI
{
    static void Main(string[] args)
    {
        int comeco = 1;
        int final = Int32.Parse(Console.ReadLine());

        while(comeco <= final)
        {
            if(comeco % 2 == 0)
                Console.Write("{0}^2 = {1}\n", comeco, comeco*comeco);
    
            comeco++;
        }
    }
}