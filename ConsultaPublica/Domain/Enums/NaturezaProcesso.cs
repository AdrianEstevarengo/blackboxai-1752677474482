using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum ClasseObjetoEnum
    {
        [Display(Name = "Educação")]
        ProcessosEducacionais,

        [Display(Name = "Especiais")]
        ProcessosEspeciais,

        [Display(Name = "Obras e Infrastrutura")]
        ProcessosObrasInfraestrutura,

        [Display(Name = "Saúde")]
        ProcessosSaude,

        [Display(Name = "Segurança")]
        ProcessosSeguranca,

        [Display(Name = "Outros")]
        ProcessosGenericos
    }
}
