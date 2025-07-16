namespace Domain.DTOs
{
    public class PropostaDTO //verificar os tipos
    {
        public string? numeroControlePNCPCompra { get; set; }
        public string? naturezaJuridicaId { get; set; }
        public string? dataAtualizacao { get; set; }
        public string? niFornecedor { get; set; }
        public string? tipoPessoa { get; set; }
        public string? numeroItem { get; set; }
        public string? nomeRazaoSocialFornecedor { get; set; }
        public string? codigoPais { get; set; }
        public int porteFornecedorId { get; set; }
        public string? quantidadeHomologada { get; set; }
        public string? percentualDesconto { get; set; }
        public bool indicadorSubcontratacao { get; set; }
        public int? ordemClassificacaoSrp { get; set; }
        public string? dataResultado { get; set; }
        public string? motivoCancelamento { get; set; }
        public int situacaoCompraItemResultadoId { get; set; }
        public string? porteFornecedorNome { get; set; }
        public string? situacaoCompraItemResultadoNome { get; set; }
        public int sequencialResultado { get; set; }
        public string? naturezaJuridicaNome { get; set; }
        public string? descricao { get; set; }

        private string? _valorUnitarioHomologado;
        private string? _valorTotalHomologado;

        public string valorUnitarioHomologado
        {
            get { return _valorUnitarioHomologado!; }
            set { _valorUnitarioHomologado = value ?? "0"; } // Define "0" como valor padrão se for nulo
        }

        public string valorTotalHomologado
        {
            get { return _valorTotalHomologado!; }
            set { _valorTotalHomologado = value ?? "0"; } // Define "0" como valor padrão se for nulo
        }
    }
}