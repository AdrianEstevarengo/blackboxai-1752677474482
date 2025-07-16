namespace Domain.DTOs
{
    public class ItemCollectionDto
    {
        public Guid Id { get; set; }
        public string? Quantidade { get; set; }
        public string? ValorEstimado { get; set; }
        public string? ValorNegociado { get; set; }
        public string? Situacao { get; set; }
        public bool? PossuiCota { get; set; }
        public string? EmpresaVencedora { get; set; }
        public bool? MeEpp { get; set; }
        public bool? DesempateRegional { get; set; }
        public bool? ro { get; set; }
    }

}