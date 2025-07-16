using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum TipoAtendimentoEnum
    {
        [Display(Name = "Gabinete")]
        GABINETE,

        [Display(Name = "Protocolo")]
        PROTOCOLO
    }
}