using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum SituacaoRequisitosEnum
    {
        [Display(Name = "Incorreto")]
        INCORRETO,

        [Display(Name = "Correto")]
        CORRETO,

        [Display(Name = "Não se Aplica ")]
        NAOAPLICA,

        [Display(Name = "Ausente no TR")]
        AUSENTE_TR,

        [Display(Name = "Compete")]
        COMPETE
    }
}