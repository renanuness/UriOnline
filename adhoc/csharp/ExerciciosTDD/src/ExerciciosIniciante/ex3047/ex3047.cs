using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosIniciante.ex3047
{
    public class URI
    {

    }

    public class ex3047
    {
        public void Executar()
        {
            var idadeDonaMaria = LerInteiro();
            var idadeFilho1 = LerInteiro();
            var idadeFilho2 = LerInteiro();
            var idadeFilho3 = idadeDonaMaria - idadeFilho1 - idadeFilho2;


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
