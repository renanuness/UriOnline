    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace ExerciciosStrings.Exercicio1262
    {
        public class URI
        {
            static void Main(string[] args)
            {
                var ex = new Ex1262();
                ex.Executar();
            }
        }

        public class Ex1262
        {
            public void Executar()
            {
                var comando = "";
                while (!string.IsNullOrEmpty(comando = LerLinha()))
                {
                    var operacoes = LerInteiro();

                    var ciclos = 0;
                    var sequenciaR = 0;
                    var contando = false;

                    foreach(var l in comando)
                    {
                        if(l == 'R' )
                        {
                            if(contando == false)
                                contando = true;
                        
                            sequenciaR++;
                        
                            if (sequenciaR == operacoes)
                            {
                                ciclos++;
                                sequenciaR = 0;
                                contando = false;
                            }
                        }
                        else if(l == 'W')
                        {
                            if(contando)
                            {
                                ciclos++;
                                contando = false;
                                sequenciaR = 0;
                            }
                            ciclos++;
                        }
                    }
                    if (contando)
                        ciclos++;

                    Console.Write("{0}\n", ciclos);
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
