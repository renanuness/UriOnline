using System;

class URI
{
    static void Main(string[] args)
    {
        int QUANTIDADE_ENTRADAS = 5;
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        for(int i = 0; i < QUANTIDADE_ENTRADAS; i++)
        {
            int valor = Int32.Parse(Console.ReadLine());

            if(valor > 0)
                positivos++;
            
            if(valor < 0)
                negativos++;

            if(valor % 2 == 0)
                pares++;
            if(valor % 2 != 0)
                impares++;
        }

        Console.Write("{0} valor(es) par(es)\n",pares);
        Console.Write("{0} valor(es) impar(es)\n",impares);
        Console.Write("{0} valor(es) positivo(s)\n",positivos);
        Console.Write("{0} valor(es) negativo(s)\n",negativos);
    }
}