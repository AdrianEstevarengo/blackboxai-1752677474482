using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum SituacaoAtendimentoEnum
    {
        [Display(Name = "Aberto")] Aberto,
        [Display(Name = "Em andamento")] Andamento,
        [Display(Name = "Concluído")] Concluido
    }
}