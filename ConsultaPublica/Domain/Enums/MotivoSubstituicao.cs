using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum MotivoSubstituicao
    {
        [Display(Name = "Férias")]
        Ferias,

        [Display(Name = "Licença")]
        Licenca,
        Recesso,
        Atestado,

        [Display(Name = "Capacitação")]
        Capacitacao
    }
}
