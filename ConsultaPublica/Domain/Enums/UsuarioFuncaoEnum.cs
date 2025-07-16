using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum UsuarioFuncaoEnum
    {
        [Display(Name = "Administrador")]
        ADMIN,

        [Display(Name = "Central de apoio")]
        CA,

        [Display(Name = "Núcleo de processamento")]
        NP,

        [Display(Name = "Pregoeiro")]
        PREGOEIRO,

        [Display(Name = "Atendimento")]
        ATENDIMENTO
    }
}