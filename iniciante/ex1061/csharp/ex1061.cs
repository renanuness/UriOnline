using System;

class URI
{
    static void Main(string[] args)
    {
        CalculadoraTempo calculadora = new CalculadoraTempo();

        calculadora.ObterEventoDatas();
        calculadora.Calcular();
        calculadora.ImprimirDuracao();
    }
}

public class CalculadoraTempo
{
    public EventoData InicioEvento {get; private set;}
    public EventoData FinalEvento {get; private set;}
    public EventoData DuracaoEvento {get; private set;}
    
    public CalculadoraTempo()
    {
        DuracaoEvento = new EventoData(0, 0, 0, 0);
    }

    public void ObterEventoDatas()
    {
        InicioEvento = LerData();
        FinalEvento = LerData();
    }

    private EventoData LerData()
    {
        string diaStr = Console.ReadLine();
        string horasStr = Console.ReadLine();
        
        int dia = Int32.Parse(diaStr.Split(' ')[1]);

        int horas = Int32.Parse(horasStr.Split(':')[0].Trim());
        int minutos = Int32.Parse(horasStr.Split(':')[1].Trim());
        int segundos = Int32.Parse(horasStr.Split(':')[2].Trim());
    
        return new EventoData(dia, horas, minutos, segundos);
    }

    public void Calcular()
    {
        var segundos = FinalEvento.Segundos - InicioEvento.Segundos;
        var minutos = FinalEvento.Minutos - InicioEvento.Minutos;
        var horas = FinalEvento.Horas - InicioEvento.Horas;
        var dias = FinalEvento.Dia - InicioEvento.Dia;
    
        var segundosNegativos = segundos < 0;
        var minutosNegativos = minutos < 0;
        var horasNegativas = horas < 0;
    
        if(segundosNegativos)
        {
            segundos += 60;
            minutos--;
        }

        if(minutosNegativos)
        {
            minutos += 60;
            horas--;
        }

        if(horasNegativas)
        {
            horas +=  24;
            dias--;
        }

        DuracaoEvento.DefinirData(dias, horas, minutos, segundos);
    }

    public void ImprimirDuracao()
    {
        Console.Write("{0} dia(s)\n", DuracaoEvento.Dia);
        Console.Write("{0} hora(s)\n", DuracaoEvento.Horas);
        Console.Write("{0} minuto(s)\n", DuracaoEvento.Minutos);
        Console.Write("{0} segundo(s)\n", DuracaoEvento.Segundos);
    }
}

public class EventoData
{
    public int Dia {get; private set;}
    public int Horas{get;private set;}
    public int Minutos{get; private set;}
    public int Segundos{get; private set;}

    public EventoData(int dia, int horas, int minutos, int segundos)
    {
        Dia = dia;
        Horas = horas;
        Minutos = minutos;
        Segundos = segundos;
    }

    public void DefinirData(int dia, int horas, int minutos, int segundos)
    {
        Dia = dia;
        Horas = horas;
        Minutos = minutos;
        Segundos = segundos;
    }
}