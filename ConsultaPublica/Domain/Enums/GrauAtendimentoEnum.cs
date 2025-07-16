using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum GrauAtendimentoEnum
    {
        [Display(Name = "Urgente")] Urgente,
        [Display(Name = "Médio")] Medio,
        [Display(Name = "Normal")] Normal
    }
}