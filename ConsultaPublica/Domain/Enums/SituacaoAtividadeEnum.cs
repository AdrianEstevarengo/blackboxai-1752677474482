using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum SituacaoAtividadeEnum
    {
        [Display(Name = "Andamento")]
        Andamento,

        [Display(Name = "Deserto")]
        Deserto,

        [Display(Name = "Êxito")]
        Exito,

        [Display(Name = "Finalizado parcial")]
        Finalizado_parcial,

        [Display(Name = "Fracassado")]
        Fracassado,

        [Display(Name = "Retorno de fase")]
        Retorno_de_fase,

        [Display(Name = "Revogado")]
        Revogado,

        [Display(Name = "Suspenso")]
        Suspenso,

        [Display(Name = "Termo de Encerramento")]
        Termo_de_Encerramento,
    }
}