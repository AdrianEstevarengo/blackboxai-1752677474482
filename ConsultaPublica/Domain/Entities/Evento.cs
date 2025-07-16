namespace Domain.Entities
{
    public class Evento
    {
        public Guid Id { get; set; }
        public int TipoEventoId { get; set; }
        public virtual TipoEvento? TipoEvento { get; set; }
        public string? Localizacao { get; set; }
        public string? Setorial { get; set; }
        public string? UnidadeExterna { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime DataCriacao { get; set; }
        public Guid AtividadeId { get; set; }
        public Atividade? Atividade { get; set; }
    }
}