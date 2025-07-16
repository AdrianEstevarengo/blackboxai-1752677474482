using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum SituacaoJulgamento
    {
        [Display(Name = "Deferido")] DEFERIDO,
        [Display(Name = "Indeferido")] INDEFERIDO,
        [Display(Name = "Em Julgamento")] JULGAMENTO
    }
}