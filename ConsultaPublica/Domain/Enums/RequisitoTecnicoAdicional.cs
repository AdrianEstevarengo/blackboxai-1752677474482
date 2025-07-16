using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum RequisitoTecnicoAdicional
    {
        Nenhum,

        [Display(Name = "Requisitos de habilitação padrão")]
        HabilitacaoPadrao, // Requisitos de habilitação padrão

        [Display(Name = "Exige análise documental específica")]
        AnaliseDocumentalEspecifica, // Exige análise documental específica

        [Display(Name = "Visita técnica e/ou amostras")]
        VisitaOuAmostras, // Visita técnica e/ou amostras

        [Display(Name = "Comissão técnica especializada")]
        ComissaoEspecializada // Comissão técnica especializada
    }
}
