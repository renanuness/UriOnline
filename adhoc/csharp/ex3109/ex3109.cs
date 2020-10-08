//TODO: Incompleto

using System;

class URI
{
    static void Main(string[] args)
    {
       new Escritorio().Core();
    }

}

public class Escritorio
{
    public int[] Empregados;
    public void Core()
    {
        var numeroEmpregados = Int32.Parse(Console.ReadLine());
        var eventos = Int32.Parse(Console.ReadLine());

        Empregados = new int[numeroEmpregados];

        while(eventos-- > 0)
        {
            var evento = LerEvento();
            var tipoEvento = DefinirTipoEvento(evento);

            if(tipoEvento == TipoEvento.Update)
                RealizarTroca(evento);
            
            if(tipoEvento == TipoEvento.Query)
            {
                var posicao = Int32.Parse(evento.Split(' ')[1]);
                Console.Write("{0}\n", Empregados[--posicao]);
            }
        }
    }

    public string LerEvento()
    {
        return Console.ReadLine();
    }

    public TipoEvento DefinirTipoEvento(string evento)
    {
        var tipoEvento = evento.Split(' ')[0] == "1" ? TipoEvento.Update : TipoEvento.Query;

        return tipoEvento;
    }

    public void RealizarTroca(string evento)
    {
        var e1 = Int32.Parse(evento.Split(' ')[1]);
        var e2 = Int32.Parse(evento.Split(' ')[2]);

        Empregados[--e1]++;
        Empregados[--e2]++;
    }
}
public enum TipoEvento
{
    Query,
    Update
}