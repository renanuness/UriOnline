using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        var casosDeTeste = Int32.Parse(Console.ReadLine());

        List<Aluno> alunos = new List<Aluno>();
        alunos.Add(new Rafael());
        alunos.Add(new Beto());
        alunos.Add(new Carlos());

        while(casosDeTeste-- > 0)
        {
            var entradas = Console.ReadLine();

            var x = Int32.Parse(entradas.Split(' ')[0]);
            var y = Int32.Parse(entradas.Split(' ')[1]);
        
            alunos.ForEach(a => a.Calcular(x, y));
            var max = alunos.Max(a => a.Resultado);
            var vencedor = alunos.Where(a => a.Resultado == max).FirstOrDefault();
            Console.Write("{0} ganhou\n", vencedor.Nome);
        }
    }
}

public abstract class Aluno
{
    public string Nome { get; protected set; }
    public int Resultado { get; protected set; }
    public abstract void Calcular(int x, int y);
}

public class Rafael : Aluno
{
    public Rafael()
    {
        Nome = "Rafael";
    }
    public override void Calcular(int x, int y)
    {
        var a = (3* x);
        a *= a;
        a += y*y;
        
        Resultado = a;
    }
}

public class Beto : Aluno
{
    public Beto()
    {
        Nome = "Beto";
    }

    public override void Calcular(int x, int y)
    {
        var a = x * x;
        a *= 2;

        var b = 5 * y;
        b *= b;
        
        Resultado = a + b;
    }
}

public class Carlos : Aluno
{
    public Carlos()
    {
        Nome = "Carlos";
    }

    public override void Calcular(int x, int y)
    {
        var a = -100 *x;
        var b = y * y * y;
        
        Resultado = a + b;
    }
}

