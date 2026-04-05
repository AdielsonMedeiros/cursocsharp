// 'using System;' permite usar classes fundamentais do C#, como a 'Console'.
using System;

namespace _01Conceitos
{
    // 'class Program' define uma classe, que é uma estrutura que contém o código.
    class Program
    {
        // 'static void Main' é o "método principal" (ponto de partida). 
        // O programa sempre começa a ser executado a partir desta linha.
        static void Main(string[] args)
        {
            // 'Console.WriteLine' escreve uma linha de texto na tela do computador.
            // "Hello, World!" é a mensagem que será exibida.
            
            Pessoa p1 = new Pessoa();
            p1.nome = "Adielson";
            p1.idade = 25;
            p1.mensagem();
            
        }
    }
}