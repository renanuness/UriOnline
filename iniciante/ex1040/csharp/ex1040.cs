using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        var notas = Console.ReadLine();
        var n1 = Double.Parse(notas.Split(' ')[0]);
        var n2 = Double.Parse(notas.Split(' ')[1]);
        var n3 = Double.Parse(notas.Split(' ')[2]);
        var n4 = Double.Parse(notas.Split(' ')[3]);

        var aluno = new Aluno(new double[]{n1,n2,n3,n4});
        
        aluno.DefinirPesos(new double[]{2.0,3.0,4.0,1.0});
        var situacao = aluno.VerificarSituacao();

        Console.Write("Media: {0:f1}\n", aluno.NotaToString(aluno.CalcularMedia()));
        Console.Write("{0}", situacao);

        if(!aluno.EmExame()) return;

        var notaExame = Double.Parse(Console.ReadLine());
        Console.Write("Nota do exame: {0:f1}\n", aluno.NotaToString(notaExame));
        aluno.DefinirNotaExame(notaExame);
        Console.Write("{0}", aluno.VerificarSituacaoAposExame());
        Console.Write("Media final: {0:f1}\n", aluno.CalcularMediaExame());
    }
}

public class Aluno
{
    public double[] Notas {get; private set;}
    public double[] Pesos {get; private set;}
    public double NotaExame {get; private set;}

    public Aluno (double[] notas)
    {
        Notas = notas;    
    }

    public void DefinirPesos(double[] pesos)
    {
        Pesos = pesos;
    }

    public void DefinirNotaExame(double nota)
    {
        NotaExame = nota;
    }

    private double CalcularTotal()
    {
        return Pesos.Sum();
    }

    public double CalcularMedia()
    {
        var total = CalcularTotal();
        var media = 0.0;
        var index = 0;

        foreach(var nota in Notas)
        {
            media += nota * (Pesos[index++]/total);
        }

        return media;
    }

    public double CalcularMediaExame()
    {
        return (CalcularMedia() + NotaExame) / 2;
    }

    public bool EmExame()
    {
        var media = CalcularMedia();
        if(media >= 5 && media <= 6.9)
            return true;

        return false;
}

    public string VerificarSituacao()
    {
        var media = CalcularMedia();
        if(media <= 4.9)
            return "Aluno reprovado.\n";       
        
        if(EmExame())
            return "Aluno em exame.\n";

        return "Aluno aprovado.\n";
    }

    public string VerificarSituacaoAposExame()
    {
        var media = CalcularMediaExame();

        if(media >= 5)
            return "Aluno aprovado.\n";

        return "Aluno reprovado\n";
    }

    public string NotaToString(double nota)
    {
        return string.Format("{0:0.0}",Math.Truncate(nota*10)/10);
    }
}