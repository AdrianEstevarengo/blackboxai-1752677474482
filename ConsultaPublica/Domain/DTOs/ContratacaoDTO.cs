namespace Domain.DTOs
{
    public class ContratacaoDTO
    {
        public string? valorTotalEstimado { get; set; }
        public string? valorTotalHomologado { get; set; }
        public object? orgaoSubRogado { get; set; }
        public UnidadeOrgaoDTO? unidadeOrgao { get; set; }
        public object? unidadeSubRogada { get; set; }
        public string? numeroCompra { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string? dataPublicacaoPncp { get; set; }
        public int? modoDisputaId { get; set; }
        public int? modalidadeId { get; set; }
        public bool? srp { get; set; }
        public int? anoCompra { get; set; }
        public int? sequencialCompra { get; set; }
        public OrgaoEntidadeDTO? orgaoEntidade { get; set; }
        public string? dataInclusao { get; set; }
        public AmparoLegalDTO? amparoLegal { get; set; }
        public string? dataAberturaProposta { get; set; }
        public string? dataEncerramentoProposta { get; set; }
        public string? informacaoComplementar { get; set; }
        public string? processo { get; set; }
        public string? objetoCompra { get; set; }
        public string? linkSistemaOrigem { get; set; }
        public object? justificativaPresencial { get; set; }
        public string? numeroControlePNCP { get; set; }
        public bool? existeResultado { get; set; }
        public string? tipoInstrumentoConvocatorioNome { get; set; }
        public string? usuarioNome { get; set; }
        public int? tipoInstrumentoConvocatorioCodigo { get; set; }
        public string? modoDisputaNome { get; set; }
        public string? situacaoCompraId { get; set; }
        public string? situacaoCompraNome { get; set; }
        public int? orcamentoSigilosoCodigo { get; set; }
        public string? orcamentoSigilosoDescricao { get; set; }
        public string? modalidadeNome { get; set; }
    }

    public class UnidadeOrgaoDTO
    {
        public string? ufNome { get; set; }
        public string? codigoUnidade { get; set; }
        public string? nomeUnidade { get; set; }
        public string? ufSigla { get; set; }
        public string? municipioNome { get; set; }
        public string? codigoIbge { get; set; }
    }

    public class OrgaoEntidadeDTO
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }
        public string? esferaId { get; set; }
        public string? poderId { get; set; }
    }

    public class AmparoLegalDTO
    {
        public int? codigo { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public string DescricaoCompleta
        {
            get { return $"{codigo} - {nome} - {descricao}"; }
        }
    }
}