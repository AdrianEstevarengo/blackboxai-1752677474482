namespace Domain.DTOs
{
    public class EventoDto
    {
        public int TipoEventoId { get; set; }
        public string? TipoEventoTitulo { get; set; }
        public string? TipoEventoDescricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}