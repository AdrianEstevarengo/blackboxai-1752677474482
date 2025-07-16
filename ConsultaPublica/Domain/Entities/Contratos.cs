using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Domain.Enums;

namespace Domain.Entities
{
    public class Contratos
    {
        public Guid Id { get; set; }
        public Guid ResponsavelPagamentoId { get; set; }

        [ForeignKey("ResponsavelPagamentoId")]
        public Funcionario? Responsavel { get; set; }

        public Guid FiscalContratoId { get; set; }

        [ForeignKey("FiscalContratoId")]
        public Funcionario? Fiscal { get; set; }

        [Required]
        [Display(Name = "Número do Processo")]
        public string NumeroProcesso { get; set; } = String.Empty;

        [Required]
        [Display(Name = "Empresa")]
        public string Empresa { get; set; } = String.Empty;

        [Required]
        [Display(Name = "Situação")]
        public SituacaoContratoEnum Situacao { get; set; }

        [Display(Name = "Observações")]
        public string? Observacoes { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Recebimento NF")]
        public DateTime? RecebimentoNf { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Prazo Da Comissão")]
        public DateTime? PrazoComissao { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Recebimento Definitivo")]
        public DateTime RecebimentoDefinitivo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Prazo Para Liquidação")]
        public DateTime? PrazoParaLiquidacao { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Prazo Para Pagamento")]
        public DateTime? PrazoPagamento { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Liquidação")]
        public DateTime? Liquidacao { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Confirmado Pagamento SIGEF")]
        public DateTime? PagamentoSigef { get; set; }

        [Required]
        [Range(0.0, Double.PositiveInfinity)]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; } = true;
    }
}