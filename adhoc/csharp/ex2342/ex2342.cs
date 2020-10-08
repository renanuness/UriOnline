using System;

class URI
{
    static void Main(string[] args)
    {
        new Calculadora().RodarPrograma();
    }
}

public class Calculadora
{
    public int Maximo {get; private set;}
    public int P {get; private set;}
    public int Q {get; private set;}
    public string Operacao {get; private set;}

    public void RodarPrograma()
    {
        LerMaximo();
        LerValoresConta();
        ImprimirResultado();
    }

    public void LerMaximo()
    {
        Maximo = Int32.Parse(Console.ReadLine());
    }

    public void LerValoresConta()
    {
        var entradas = Console.ReadLine();

        P = Int32.Parse(entradas.Split(' ')[0]);
        Operacao = entradas.Split(' ')[1];
        Q = Int32.Parse(entradas.Split(' ')[2]);
    }

    private void ImprimirResultado()
    {
        string resultado = "OK";
        if(CalcularTotal() > Maximo)
            resultado = "OVERFLOW";

        Console.Write("{0}\n", resultado);
    }

    public int CalcularTotal()
    {
        var total =  Operacao == "*" ? Multiplicar() : Somar();
        return total;
    }

    private int Multiplicar() => P * Q;
    private int Somar() => P + Q;
}