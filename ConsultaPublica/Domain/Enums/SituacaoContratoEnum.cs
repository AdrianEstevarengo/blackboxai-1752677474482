using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum SituacaoContratoEnum
    {
        [Display(Name = "Pagamento")]
        Pagamento,
        [Display(Name = "Liquidação")]
        Liquidacao,
        [Display(Name = "Concluído")]
        Concluido,
        [Display(Name = "Pendência")]
        Pendencia

    }
}