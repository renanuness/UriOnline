using System;

class URI
{
    static void Main(string[] args)
    {
        var I = 1;
        var J = 60;
        while(J >= 0)
        {
            Console.Write("I={0} J={1}\n", I, J);
            I += 3;
            J -= 5;
        }
    }
}