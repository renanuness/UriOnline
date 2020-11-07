using System;
using System.Collections.Generic;
using System.Linq;

public class URI
{
    static void Main(string[] args)
    {
        List<int> resultados = new List<int>();
        while(true)
        {
            var entradas = Console.ReadLine();
            if (string.IsNullOrEmpty(entradas))
                break;

            var ladoA = Int32.Parse(entradas.Split(' ')[0]);
            var ladoB = Int32.Parse(entradas.Split(' ')[1]);

            List<int> lados = new List<int>();
            lados.Add(ladoA);
            lados.Add(ladoB);

            MDC calculadorMdc = new MDC(lados);
          
            var mdc = ladoA == ladoB ? ladoA : calculadorMdc.Calcular();

            var perimetro = CalcularPerimetro(ladoA, ladoB);

            var resultado = perimetro / mdc;

            resultados.Add(resultado);
        }

        foreach(var resultado in resultados)
            ImprimirResultado(resultado);
    }

    public static void ImprimirResultado(int resultado)
    {
        Console.Write("{0}\n", resultado);
    }

    private static int CalcularPerimetro(int ladoA, int ladoB)
    {
        return ladoA * 2 + ladoB * 2;
    }
}

    public class MDC
    {
        public List<int> Valores {get; private set;}
        public int ValorB {get; private set;}

        public MDC (List<int> valores)
        {
            Valores = valores;
            Valores.Sort();
        }

        public int Calcular()
        {
            List<int> divisores = new List<int>();
            var limite = 299;
            var divisor = 2;

            do{
                if(EhDivisorComum(divisor))
                {
                    divisores.Add(divisor);
                    DividirTodos(divisor);
                }
                else
                {
                    divisor++;
                }

                if(TemUm())
                    break;

            }while(divisor <= limite);

            return CalcularMDC(divisores);
        } 

        private bool EhDivisorComum(int divisor)
        {
            foreach(var valor in Valores)
            {   
                if(!EhDivisor(divisor, valor))
                    return false;
            }

            return true;
        }

        private bool EhDivisor(int divisor, int valor)
        {
            return valor % divisor == 0;
        }

        private void DividirTodos(int divisor)
        {
            for(int i = 0; i < Valores.Count; i++)
                Valores[i] = Valores[i] / divisor;
        }

        private int CalcularMDC(List<int> valores)
        {
            var mdc = 1;
            foreach(var valor in valores)
                mdc *= valor;

            return mdc;
        }

        private int ProximoDivisor(int menorValor)
        {
            var divisor = 2;
            var limite = divisor / 2;
            while(true)
            {
                if(menorValor % divisor == 0)
                    return menorValor / divisor;
                
                divisor++;
                if(divisor == limite)
                    return 1;
            }
        }

        private bool TemUm()
        {
            var um = Valores.FirstOrDefault(x => x == 1);
            
            if(um == 1)
                return true;
            
            return false;
        }
    }