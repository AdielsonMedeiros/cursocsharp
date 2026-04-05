using System;

class Pessoa
{
    public void Apresentar( )
    {
        Console.WriteLine("olaaa");
    }


    public void Apresentar(string nome)
    {
        
        Console.WriteLine("olaaa" + nome);

    }

    public void Apresentar(string nome, int idade)
    {
        Console.WriteLine("olaaa" + nome + "voce tem" + idade + "anos");
    }
}


