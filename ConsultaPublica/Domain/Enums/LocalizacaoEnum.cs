using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum LocalizacaoEnum
    {
        [Display(Name = "Interno")]
        Interno,

        [Display(Name = "Externo")]
        Externo,

        [Display(Name = "Finalizado")]
        Finalizado,
    }
}