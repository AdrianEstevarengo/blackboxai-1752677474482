using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProcessoAgenda
    {
        [Key]
        public Guid Id { get; set; }
        public string NumeroProcesso { get; set; } = string.Empty;
        public int UnidadeGestoraId { get; set; }
        public bool Prioridade { get; set; }
        public string? IdPrioridade { get; set; }
        public string? MotivoPrioridade { get; set; }
        public DateTime? DataConclusaoInterna { get; set; }
        public DateTime? DataConclusaoExterna { get; set; }
        public DateTime? DataPrevisao { get; set; }
        public string? Situacao { get; set; }
        public string? Objeto { get; set; }
        public SubObjetoAtividadeEnum? Temas { get; set; }
        public virtual ICollection<Evento>? Eventos { get; set; } = new List<Evento>();
    }
}
