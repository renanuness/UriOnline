using System;

class URI
{
    static void Main(string[] args)
    {
        var casosDeTeste = Int32.Parse(Console.ReadLine());
        
        while(casosDeTeste-- > 0)
        {
            var entradas = Console.ReadLine();

            var a = entradas.Split(' ')[0];
            var b = entradas.Split(' ')[1];
        
            var encaixa = true; 


            if(b.Length > a.Length)
            {
                encaixa = false;
                Imprimir(encaixa);
                continue;
            }

            var comprimentoA =  a.Length;
            for(int i = b.Length - 1; i >= 0; i--)
            {
                if(a[--comprimentoA] != b[i])
                {
                    encaixa = false;
                    break;
                }
            }

            Imprimir(encaixa);
        }
    }

    public static void Imprimir(bool encaixa)
    {
        string naoEncaixaStr = "nao encaixa";
        string encaixaStr = "encaixa";
        
        var s = encaixa ? encaixaStr : naoEncaixaStr; 
        Console.Write("{0}\n", s);
    }
}