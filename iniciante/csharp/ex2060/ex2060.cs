using System;

class URI
{
    static void Main(string[] args)
    {
        var divisivel = new Divisivel();

        divisivel.DefinirDivisiveis(new int[]{2,3,4,5});
        divisivel.LerQuantidadeValores();
        divisivel.LerValores();
        divisivel.ContarDivisiveis();
    }
}

public class Divisivel
{
        private int QuantidadeValores {get;  set;}
        private int[] Valores {get;  set;}
        private int[] Divisiveis {get;  set;}
        

        public void LerQuantidadeValores()
        {
            QuantidadeValores = Int32.Parse(Console.ReadLine());
            Valores = new int[QuantidadeValores];
        }

        public void LerValores()
        {
            string valoresString = Console.ReadLine(); 
            for(int i = 0; i < QuantidadeValores; i++)
            {
                Valores[i] = Int32.Parse(valoresString.Split(' ')[i]);
            }
        }

        public void DefinirDivisiveis(int[] divisiveis)
        {
            Divisiveis = divisiveis;
        }

        public void ContarDivisiveis()
        {
            for(int i = 0; i < Divisiveis.Length; i++)
            {
                int contador = 0;
                for(int j = 0; j < QuantidadeValores; j++)
                {
                    if(DivisivelPor(Valores[j], Divisiveis[i]))
                        contador++;
                }
                Console.Write("{0} Multiplo(s) de {1}\n", contador, Divisiveis[i].ToString());
            }
        }

        private  bool DivisivelPor(int valor, int divisivel)
        {
            if(valor % divisivel == 0)
                return true;

            return false;
        }
}