using System;

class URI
{
    static void Main(string[] args)
    {
        new GerenciadorSenha().LerValores();
    }
}

public class GerenciadorSenha
{

    public void LerValores()
    {
        while(LerSenha())
        {
        }
    }
    private bool LerSenha()
    {
        string entrada = Console.ReadLine();
        if(string.IsNullOrEmpty(entrada))
            return false;
        
        int senha = Int32.Parse(entrada);
        Console.Write("{0}\n", --senha); 
        return true;       
    }
}