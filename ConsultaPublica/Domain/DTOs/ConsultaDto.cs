using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs
{
    public class ConsultaDto
    {
        [Display(Name = "Palavra-chave")]
        public string PalavraChave { get; set; }

        [Display(Name = "Número do Processo")]
        [RegularExpression(
            @"^\d{4}\.\d{6}/\d{4}-\d{2}$",
            ErrorMessage = "Formato inválido. Use: 0000.000000/0000-00"
        )]
        public string NumeroProcesso { get; set; }

        [Display(Name = "Data Inicial")]
        [DataType(DataType.Date)]
        public DateTime? DataInicial { get; set; }

        [Display(Name = "Data Final")]
        [DataType(DataType.Date)]
        public DateTime? DataFinal { get; set; }

        [Display(Name = "Em Andamento")]
        public bool EmAndamento { get; set; } = true;

        [Display(Name = "Concluídos")]
        public bool Concluidos { get; set; } = true;

        [Display(Name = "Atrasados")]
        public bool Atrasados { get; set; } = true;

        [Display(Name = "Deserto")]
        public bool Deserto { get; set; } = true;

        [Display(Name = "Revogado")]

        public bool Revogado { get; set; }

        [Display(Name = "Sub Objeto")]
        public SubObjetoAtividadeEnum? SubObjeto { get; set; } = null; // MUDANÇA AQUI

        [Display(Name = "EOrgao")]
        public EOrgao? EOrgao { get; set; } = null;

        [Display(Name = "Unidade Gestora")]
        public int? UnidadeGestoraId { get; set; }


        // Método para validar se as datas são consistentes
        public bool ValidarDatas()
        {
            if (DataInicial.HasValue && DataFinal.HasValue)
            {
                return DataInicial.Value <= DataFinal.Value;
            }
            return true;
        }

        // Método para verificar se o filtro está vazio
        public bool FiltroVazio()
        {
            return string.IsNullOrWhiteSpace(PalavraChave)
                && string.IsNullOrWhiteSpace(NumeroProcesso)
                && !DataInicial.HasValue
                && !DataFinal.HasValue;
        }
    }
}
