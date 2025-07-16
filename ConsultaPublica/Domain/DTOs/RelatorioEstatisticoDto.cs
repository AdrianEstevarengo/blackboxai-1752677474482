namespace Domain.DTOs
{
    public class RelatorioEstatisticoDto
    {
        public Guid Id { get; set; }
        public string? Legislacao { get; set; }
        public string? NumeroDoProcesso { get; set; }
        public string? NumeroDoCertame { get; set; }
        public string? Objeto { get; set; }
        public string? IdContratacaoPNCP { get; set; }
        public string? dataPublicacaoPncp { get; set; }
        public string? dataAberturaProposta { get; set; }
        public string? dataEncerramentoProposta { get; set; }
        public DateTime DataCriacaoRelatorio { get; set; }
        public string? Ano { get; set; }
        public string? ValorEstimadoGlobal { get; set; }
        public string? ValorNegociadoGlobal { get; set; }
        public string? Pregoeiro { get; set; }
        public string? ElaboradoPor { get; set; }
        public string? RevisadoPor { get; set; }
        public List<ItemCollectionDto> ItemsCollection { get; set; } = new();
    }
}