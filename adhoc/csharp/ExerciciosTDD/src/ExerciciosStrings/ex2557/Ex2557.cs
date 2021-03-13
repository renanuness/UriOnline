using System;

namespace ExerciciosStrings.Exercicio2557
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex2557();
            ex.Executar();
        }
    }

    public class Ex2557
    {
        public void Executar()
        {
            var entrada = "";
            while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
            {
                int resultado = 0;
                var valores = entrada.Split('+', '=');

                int result;
                if(int.TryParse(valores[2], out result))
                {
                    int segundoTermo;
                    if(int.TryParse(valores[0], out segundoTermo))
                    {
                        resultado = result - segundoTermo;
                    }
                    else if (int.TryParse(valores[1], out segundoTermo))
                    {
                        resultado = result - segundoTermo;
                    }
                }
                else
                {
                    resultado = int.Parse(valores[0]) + int.Parse(valores[1]);
                }
                Console.Write("{0}\n", resultado);
            }
        }
    }
}
