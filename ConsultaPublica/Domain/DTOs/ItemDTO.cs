namespace Domain.DTOs
{
    public class ItemDTO //verificar os tipos
    {
        public int numeroItem { get; set; }
        public string descricao { get; set; } = string.Empty;
        public string materialOuServico { get; set; } = string.Empty;
        public string materialOuServicoNome { get; set; } = string.Empty;
        public string valorUnitarioEstimado { get; set; } = string.Empty;
        public string valorTotal { get; set; } = string.Empty;
        public string quantidade { get; set; } = string.Empty;
        public string unidadeMedida { get; set; } = string.Empty;
        public bool orcamentoSigiloso { get; set; }
        public int itemCategoriaId { get; set; }
        public string itemCategoriaNome { get; set; } = string.Empty;
        public object patrimonio { get; set; } = string.Empty;
        public object codigoRegistroImobiliario { get; set; } = string.Empty;
        public int criterioJulgamentoId { get; set; }
        public string criterioJulgamentoNome { get; set; } = string.Empty;
        public int situacaoCompraItem { get; set; }
        public string situacaoCompraItemNome { get; set; } = string.Empty;
        public int tipoBeneficio { get; set; }
        public string tipoBeneficioNome { get; set; } = string.Empty;
        public bool incentivoProdutivoBasico { get; set; }
        public DateTime dataInclusao { get; set; }
        public DateTime dataAtualizacao { get; set; }
        public bool temResultado { get; set; }
        public int imagem { get; set; }

        public string tratamentoDiferenciado { get; set; } = string.Empty;
        public bool aplicabilidadeDecreto7174 { get; set; }
        public bool aplicabilidadeMargemPreferencial { get; set; }
    }
}