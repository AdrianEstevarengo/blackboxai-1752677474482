namespace Domain.Entities
{
    public class Checklist
    {
        public Guid Id { get; set; }
        public Guid AtividadeId { get; set; }
        public Atividade? Atividade { get; set; }
        public int NItem { get; set; }
        public string Situacao { get; set; } = string.Empty;
        public string Pergunta { get; set; } = string.Empty;
        public string? Observacao { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}