using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace AgendaConsulta.Models
{
    public class ProcessoAgendaViewModel
    {
        public ProcessoAgendaViewModel()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }

        public Guid Id { get; set; }

        [Display(Name = "Numero De Processo")]
        public string NumeroProcesso { get; set; } = string.Empty;

        [Display(Name = "Unidade Gestora")]
        public int UnidadeGestoraId { get; set; }

        [Display(Name = "Natureza de Objeto")]
        public ClasseObjetoEnum? ClasseObjeto { get; set; }

        [Display(Name = "Prioridade")]
        public bool Prioridade { get; set; }
        public string? IdPrioridade { get; set; }
        public string? MotivoPrioridade { get; set; }

        [Display(Name = "Data De Conclusão Interna")]
        public DateTime? DataConclusaoInterna { get; set; }

        [Display(Name = "Data De Conclusão Externa")]
        public DateTime? DataConclusaoExterna { get; set; }

        [Display(Name = "Data De Previsão")]
        public DateTime? DataPrevisao { get; set; }

        [Display(Name = "Data De Criação")]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data De Entrada")]
        public DateTime DataEntrada { get; set; }

        [Display(Name = "Situação")]
        public string? Situacao { get; set; }

        [Display(Name = "Objeto")]
        public string Objeto { get; set; }
        public SubObjetoAtividadeEnum? Temas { get; set; }
        public ICollection<EventoViewModel>? Eventos { get; set; }
        public EventoViewModel? UltimoEvento { get; set; }
        public object NumeroCertame { get; internal set; }
        public object Mesa { get; internal set; }
        public string? Progresso { get; set; }
    }
}
