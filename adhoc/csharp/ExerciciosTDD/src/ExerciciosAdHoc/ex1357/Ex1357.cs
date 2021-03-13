using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExerciciosAdHoc.Exercicio1357
{
    public class URI
    {
        static void Main(string[] args)
        {
            var ex = new Ex1357();
            ex.Executar();
        }

        public static int LerInteiro()
        {
            return int.Parse(LerLinha());
        }

        public static string LerLinha()
        {
            return Console.ReadLine();
        }
    }

    public class Ex1357
    {
        ITradutor tradutor;
        public void Executar()
        {
            var letras = 0;
            while ((letras = URI.LerInteiro()) != 0)
            {
                var digito = URI.LerLinha() == "S" ? DIGITO.NUMERO : DIGITO.BRAILE;

                if (digito == DIGITO.BRAILE)
                    tradutor = new TradutorBraile();
                else
                    tradutor = new TradutorDigitos();

                tradutor.Traduzir();
                tradutor.Imprimir();
            }
        }
    }

    public interface ITradutor
    {
        void Traduzir();
        void Imprimir();
    }

    public class TradutorDigitos : ITradutor
    {
        public string _digitos { get; private set; }
        public List<string> letras { get; set; }


        public TradutorDigitos()
        {
            _digitos = URI.LerLinha();
        }

        public void Traduzir()
        {
            var dicionario = DicionarioDB.Dicionario;
            letras = new List<string>();
            letras.Add("");
            letras.Add("");
            letras.Add("");

            for (int j = 0; j < _digitos.Length; j++)
            {
                var d = _digitos[j];
                var dInteiro = int.Parse(d.ToString());
                var letraBraile = dicionario[dInteiro];

                for (int i = 0; i < letraBraile.Count; i++)
                {
                    letras[i] += letraBraile[i];
                    if (j != _digitos.Length - 1)
                        letras[i] += " ";
                }

            }
        }

        public void Imprimir()
        {
            foreach (var d in letras)
                Console.Write("{0}\n", d);
        }
    }

    public class TradutorBraile : ITradutor
    {
        public List<string> _braile { get; private set; }
        public string _digitos { get; private set; }

        public TradutorBraile()
        {
            _braile = new List<string>();
            _braile.Add(URI.LerLinha());
            _braile.Add(URI.LerLinha());
            _braile.Add(URI.LerLinha());
        }

        public void Traduzir()
        {
            var linha1 = _braile[0].Split(' ');
            var linha2 = _braile[1].Split(' ');
            var linha3 = _braile[2].Split(' ');

            var dicionario = DicionarioDB.Dicionario;

            var sb = new StringBuilder();
            for(int i = 0; i < linha1.Length; i++)
            {
                var l = new List<string>();
                l.Add(linha1[i]);
                l.Add(linha2[i]);
                l.Add(linha3[i]);

                var d = dicionario.FirstOrDefault(x => x.Value.Comparar(l));
                sb.Append(d.Key);
            }

            _digitos = sb.ToString();
        }

        public void Imprimir()
        {
            Console.Write("{0}\n", _digitos);
        }
    }

    public static class DicionarioDB
    {
        public static bool Inicializado = false;

        private static Dictionary<int, List<string>> _dicionario;

        public static Dictionary<int, List<string>> Dicionario
        {
            get
            {
                if (_dicionario == null)
                    InicializarLetras();
                return _dicionario;
            }
            private set { }
        }

        public static void InicializarLetras()
        {
            Dictionary<int, List<string>> dicionario = new Dictionary<int, List<string>>();

            var um = new List<string>();
            um.Add("*.");
            um.Add("..");
            um.Add("..");
            dicionario.Add(1, um);

            var dois = new List<string>();
            dois.Add("*.");
            dois.Add("*.");
            dois.Add("..");
            dicionario.Add(2, dois);

            var tres = new List<string>();
            tres.Add("**");
            tres.Add("..");
            tres.Add("..");
            dicionario.Add(3, tres);

            var quatro = new List<string>();
            quatro.Add("**");
            quatro.Add(".*");
            quatro.Add("..");
            dicionario.Add(4, quatro);

            var cinco = new List<string>();
            cinco.Add("*.");
            cinco.Add(".*");
            cinco.Add("..");
            dicionario.Add(5, cinco);

            var seis = new List<string>();
            seis.Add("**");
            seis.Add("*.");
            seis.Add("..");
            dicionario.Add(6, seis);

            var sete = new List<string>();
            sete.Add("**");
            sete.Add("**");
            sete.Add("..");
            dicionario.Add(7, sete);

            var oito = new List<string>();
            oito.Add("*.");
            oito.Add("**");
            oito.Add("..");
            dicionario.Add(8, oito);

            var nove = new List<string>();
            nove.Add(".*");
            nove.Add("*.");
            nove.Add("..");
            dicionario.Add(9, nove);

            var zero = new List<string>();
            zero.Add(".*");
            zero.Add("**");
            zero.Add("..");
            dicionario.Add(0, zero);

            Inicializado = true;
            _dicionario = dicionario;
        }
    }

    public enum DIGITO
    {
        NUMERO,
        BRAILE
    }

    public static class Extension
    {
        public static bool Comparar(this List<string> value, List<string> other)
        {
            var index = 0;
            foreach(var l in value)
            {
                if (l != other[index])
                    return false;

                index++;
            }

            return true;
        }
    }
}
