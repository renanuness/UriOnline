using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosAdHoc.Exercicio1426
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1426();
            ex.Executar();
        }
    }

    public class Ex1426
    {
        List<Tijolo[]> parede { get; set; }

        public void InicializarParede()
        {
            parede = new List<Tijolo[]>();

            for (int i = 0; i < 9; i++)
            {
                parede.Add(new Tijolo[i + 1]);
                for(int j = 0; j < parede[i].Length; j++)
                {
                    parede[i][j] = new Tijolo();
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for(int j = 0; j < parede[i].Length; j++)
                {
                    parede[i][j].TijoloEsquerda = parede[i + 1][j];
                    parede[i][j].TijoloDireita = parede[i + 1][j+1];
                }
            }
        }


        public void Executar()
        {
            var casos = LerInteiro();
            while (casos-- > 0)
            {
                InicializarParede();
                
                var linha1= LerInteiro();
                var linha3 = LerMultiplasEntradas(2);
                var linha5 = LerMultiplasEntradas(3);
                var linha7 = LerMultiplasEntradas(4);
                var linha9 = LerMultiplasEntradas(5);

                parede[0][0].Valor = linha1;
                parede[0][0].Calculado = true;

                parede[2][0].Valor = linha3[0];
                parede[2][2].Valor = linha3[1];
                parede[2][0].Calculado = true;
                parede[2][2].Calculado = true;


                parede[4][0].Valor = linha5[0];
                parede[4][2].Valor = linha5[1];
                parede[4][4].Valor = linha5[2];
                parede[4][0].Calculado = true;
                parede[4][2].Calculado = true;
                parede[4][4].Calculado = true;


                parede[6][0].Valor = linha7[0];
                parede[6][2].Valor = linha7[1];
                parede[6][4].Valor = linha7[2];
                parede[6][6].Valor = linha7[3];
                parede[6][0].Calculado = true;
                parede[6][2].Calculado = true;
                parede[6][4].Calculado = true;
                parede[6][6].Calculado = true;


                parede[8][0].Valor = linha9[0];
                parede[8][2].Valor = linha9[1];
                parede[8][4].Valor = linha9[2];
                parede[8][6].Valor = linha9[3];
                parede[8][8].Valor = linha9[4];
                parede[8][0].Calculado = true;
                parede[8][2].Calculado = true;
                parede[8][4].Calculado = true;
                parede[8][6].Calculado = true;
                parede[8][8].Calculado = true;

                CalcularValoresFaltantes();
                Imprimir();
            }
        }

        private void Imprimir()
        {
            for (int i = 0; i < parede.Count; i++)
            {
                for (int j = 0; j < parede[i].Length; j++)
                {
                    Console.Write("{0}", parede[i][j].Valor);
                    if (j < parede[i].Length - 1)
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        private void CalcularValoresFaltantes()
        {
            for(int i = 0; i < parede.Count-2; i++)
            {
                for(int j = 0; j < parede[i].Length; j++)   
                {
                    var a = parede[i][j];
                    var b = a.TijoloEsquerda;
                    var c = a.TijoloDireita;
                    var d = b.TijoloEsquerda;
                    var e = b.TijoloDireita;
                    var f = c.TijoloDireita;

                    if (a.Calculado == false || d.Calculado == false || f.Calculado == false)
                        continue;

                    e.Valor = e.Calculado == false ? (a.Valor - d.Valor - f.Valor) / 2 : e.Valor;
                    b.Valor = b.Calculado == false ? d.Valor + e.Valor : b.Valor;
                    c.Valor = c.Calculado == false ? e.Valor + f.Valor : c.Valor;

                    e.Calculado = true;
                    b.Calculado = true;
                    c.Calculado = true;

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

        private int[] LerMultiplasEntradas(int entradas)
        {
            var entrada = LerLinha();

            if (string.IsNullOrEmpty(entrada))
                return null;

            int[] valores = new int[entradas];
            var entradaArray = entrada.Split(' ');
            for (int i = 0; i < entradas; i++)
            {
                valores[i] = int.Parse(entradaArray[i]);
            }

            return valores;
        }
    }

    public class Tijolo
    {
        public Tijolo TijoloEsquerda { get; set; }
        public Tijolo TijoloDireita { get; set; }
        public int Valor { get; set; }
        public bool Calculado { get; set; }

        public Tijolo()
        {
            Calculado = false;
        }
    }
}
