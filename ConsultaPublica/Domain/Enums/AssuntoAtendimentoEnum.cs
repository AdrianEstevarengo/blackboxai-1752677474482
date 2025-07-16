using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum AssuntoAtendimentoEnum
    {
        [Display(Name = "Chamamento público")]
        ChamamentoPublico,

        [Display(Name = "Pregão Eletrônico")]
        PregaoEletronico,

        [Display(Name = "Processo sobre obras")]
        ProcessoObras,

        [Display(Name = "Planilha de composição de custos")]
        PlanilhaComposicaoCustos,

        [Display(Name = "Dificuldade de consultas a processos")]
        DificuldadesConsultaProcessos,

        [Display(Name = "Outros")]
        Outros
    }
}