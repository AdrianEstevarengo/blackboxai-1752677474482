using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum FuncionarioClassificacaoEnum
    {
        [Display(Name = "Pregoeiro")]
        Pregoeiro,
        [Display(Name = "Pregoeiro Substituto")]
        PregoeiroSubstituto,
        [Display(Name = "Fiscal Contrato")]
        FiscalContrato,
        [Display(Name = "Responsavel Contrato")]
        ResponsavelContrato,
    }
}