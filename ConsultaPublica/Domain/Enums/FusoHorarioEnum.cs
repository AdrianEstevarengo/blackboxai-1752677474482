using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum FusoHorarioEnum
    {
        [Display(Name = "Horário de Rondônia")]
        AMT,

        [Display(Name = "Horário de Brasília")]
        BRT,
    }
}