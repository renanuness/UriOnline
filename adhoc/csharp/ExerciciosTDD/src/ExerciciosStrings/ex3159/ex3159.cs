using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosStrings.ex3159
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex3159();
            ex.Executar();
        }
    }

    public class Ex3159
    {
        private Dictionary<char, string> _comandos;
        private List<string> _palavras;

        public IReadOnlyDictionary<char, string> Comandos => _comandos;
        public IReadOnlyList<string> Palavras => _palavras;

        public Ex3159()
        {
            InicializarComandos();
        }
        
        private void InicializarComandos()
        {
            _comandos = new Dictionary<char, string>();

            _comandos.Add('a', "2");
            _comandos.Add('b', "22");
            _comandos.Add('c', "222");

            _comandos.Add('d', "3");
            _comandos.Add('e', "33");
            _comandos.Add('f', "333");

            _comandos.Add('g', "4");
            _comandos.Add('h', "44");
            _comandos.Add('i', "444");

            _comandos.Add('j', "5");
            _comandos.Add('k', "55");
            _comandos.Add('l', "555");

            _comandos.Add('m', "6");
            _comandos.Add('n', "66");
            _comandos.Add('o', "666");

            _comandos.Add('p', "7");
            _comandos.Add('q', "77");
            _comandos.Add('r', "777");
            _comandos.Add('s', "7777");

            _comandos.Add('t', "8");
            _comandos.Add('u', "88");
            _comandos.Add('v', "888");

            _comandos.Add('w', "9");
            _comandos.Add('x', "99");
            _comandos.Add('y', "999");
            _comandos.Add('z', "9999");
        }

        public void Executar()
        {
            var repeticoes = LerInteiro();

            while (repeticoes-- > 0)
            {
                var traducao = TraduzirTexto(Console.ReadLine());
                Console.Write("{0}\n", traducao);
            }
        }

        public string TraduzirTexto(string texto)
        {
            StringBuilder traducao = new StringBuilder();

            traducao.Append(ProcessarPalavra(texto));

            return traducao.ToString();
        }

        private string ProcessarPalavra(string palavra)
        {
            bool ehMaiuscula = false;
            StringBuilder traducao = new StringBuilder();

            foreach (var key in palavra)
            {
                if (key == ' ')
                {
                    traducao.Append('0');
                    continue;
                }    

                ehMaiuscula = (key >= 65 && key <= 90);

                var codigoLetra = EncontrarTecla(key);

                if (ehMaiuscula)
                    traducao.Append('#');
                else if (traducao.Length > 0 && traducao[traducao.Length-1] == codigoLetra[0])
                    traducao.Append('*');

                traducao.Append(codigoLetra);
            }

            return traducao.ToString();
        }
        
        public string EncontrarTecla(char key)
        {
            var ehMaiuscula = (key >= 65 && key <= 97);

            key = ehMaiuscula ? Char.ToLower(key) : key;
            
            return _comandos[key];
        }

        private string LerLinha()
        {
            return Console.ReadLine();
        }

        private int LerInteiro()
        {
            return int.Parse(LerLinha());
        }
    }

}
