using System.ComponentModel.DataAnnotations;

namespace AgendaConsulta.Models
{
    public class ConsultaViewModel
    {
        [Display(Name = "Busque seu Processo")]
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
