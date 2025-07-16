using Domain.Entities;

namespace Domain.DTOs
{
    public class AtividadeTransparenciaDto
    {
        public string NumeroProcesso { get; set; } = string.Empty;
        public string NumeroCertame { get; set; } = string.Empty;
        public string Objeto { get; set; } = string.Empty;
        public string IdPNCP { get; set; } = string.Empty;
        public string Legislacao { get; set; } = string.Empty;
        public string Situacao { get; set; } = string.Empty;
        public string Modalidade { get; set; } = string.Empty;
        public DateTime DataEntrada { get; set; }
        public EventoDto? UltimoEvento { get; set; }
        public UnidadeGestora? UnidadeGestora { get; set; }
        public DateTime? DataAberturaCertame { get; set; }
        public string? SubObjeto { get; set; }
    }
}