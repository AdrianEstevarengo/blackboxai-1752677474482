using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum TipoPregoeiro
    {
        [Display(Name = "Pregoeiro")] Pregoeiro,
        [Display(Name = "Pregoeiro Substituto")] PregoeiroSubstituto,
    }
}