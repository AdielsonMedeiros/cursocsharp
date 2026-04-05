using System;

namespace _01Conceitos
{
    class Pessoa
    {
        // Atributos
        public string? nome;
        public int idade;

        // Método
        public void mensagem()
        {
            // Corrigido de 'Cosnole' para 'Console'
            Console.WriteLine("Olá, meu nome é " + nome + " e eu tenho " + idade + " anos.");
        }
    }
}
