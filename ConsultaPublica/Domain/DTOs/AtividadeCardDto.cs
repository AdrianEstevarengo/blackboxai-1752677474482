using Domain.Entities;

namespace Domain.DTOs
{
    public class AtividadeCardDto
    {
        public Guid Id { get; set; }
        public string NumeroProcesso { get; set; } = string.Empty;
        public string NumeroCertame { get; set; } = string.Empty;
        public string Mesa { get; set; } = string.Empty;
        public string Objeto { get; set; } = string.Empty;
        public string IdPNCP { get; set; } = string.Empty;
        public string Legislacao { get; set; } = string.Empty;
        public string Situacao { get; set; } = string.Empty;
        public string? MotivoRevogacao { get; set; }
        public string Localizacao { get; set; } = string.Empty;
        public string Modalidade { get; set; } = string.Empty;
        public DateTime DataEntrada { get; set; }
        public int UnidadeGestoraId { get; set; }
        public bool Prioridade { get; set; }
        public string? IdPrioridade { get; set; }
        public string? MotivoPrioridade { get; set; }
        public DateTime? DataPrevisao { get; set; }
        public EventoDto? UltimoEvento { get; set; }
        public bool EstaNaMesa { get; set; }
        public UnidadeGestora? UnidadeGestora { get; set; }
        public DateTime? DataAberturaCertame { get; set; }
        public string? FusoHorarioAbertura { get; set; }
        public string? SubObjeto { get; set; }
        public List<RelatorioEstatisticoDto>? RelatorioEstatistico { get; set; }
    }
}