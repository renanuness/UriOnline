using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosStrings.Exercicio1248
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1248();
            ex.Executar();
        }
    }

    public class Ex1248
    {
        public void Executar()
        {
            var casos = LerInteiro();
            while(casos-- > 0)
            {
                var dieta = LerLinha();
                var cafe = LerLinha();
                var almoco = LerLinha();

                var comida = cafe + almoco;
                var jantar = new StringBuilder();

                if (comida.Length > dieta.Length)
                {
                    Console.Write("CHEATER\n");
                    continue;
                }
                else
                {
                    bool cheater = false;
                    for (int i = 0; i < comida.Length; i++)
                    {
                        var l = comida[i];
                        int index = dieta.LastIndexOf(l);
                        if (index == -1)
                        {
                            cheater = true;
                            break;
                        }
                        else
                        {
                            dieta = dieta.Remove(index, 1);
                        }
                        
                    }
                    if(cheater)
                    {
                        Console.Write("CHEATER\n");
                    }
                    else
                    {
                        var A = dieta.OrderBy(x => x);
                        foreach (var l in A)
                            Console.Write("{0}", l);

                        Console.Write("\n");
                    }
                }
            }
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }
    }
}
