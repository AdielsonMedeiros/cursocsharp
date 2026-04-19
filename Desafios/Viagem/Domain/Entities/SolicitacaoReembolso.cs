namespace Viagem.Domain.Entities;

public class SolicitacaoReembolso
{
    public string? ClienteNome { get; set; }

    public decimal ValorTotal { get; set; }

    public string? Descricao { get; set; }
    
    public int Id { get; set; }

    public SolicitacaoReembolso() { }

    public SolicitacaoReembolso(string nome, decimal valorTotal, string descricao)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome do cliente é obrigatório.");

        if (valorTotal <= 0)
            throw new ArgumentException("O valor total deve ser maior que zero.");

        ClienteNome = nome;
        ValorTotal = valorTotal;
        Descricao = descricao;
    }
}