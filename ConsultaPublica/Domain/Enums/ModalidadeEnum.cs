using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum ModalidadeEnum
    {
        [Display(Name = "Chamamento Público")]
        CHP,

        [Display(Name = "Concorrência")]
        CP,

        [Display(Name = "Pregão Eletrônico")]
        PE,

        [Display(Name = "Tomada de Preços")]
        TP,

        [Display(Name = "Pregão Eletrônico para Registro de Preços")]
        PERP,

        [Display(Name = "Pregão Presencial para Registro de Preços")] //REMOVER DPS ESPERANDO PAMELA
        PPRP,
    }
}