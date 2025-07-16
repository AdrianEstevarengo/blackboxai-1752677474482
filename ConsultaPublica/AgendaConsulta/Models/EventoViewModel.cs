using System.ComponentModel;
using AgendaConsulta.ViewModels;
using Domain.Enums;

namespace AgendaConsulta.Models
{
    public class EventoViewModel
    {
        public EventoViewModel()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }

        public Guid Id { get; set; }
        public int TipoEventoId { get; set; }
        public virtual TipoEventoViewModel TipoEvento { get; set; } = new TipoEventoViewModel();

        [DisplayName("Localização")]
        public LocalizacaoEnum? Localizacao { get; set; }

        [DisplayName("Setorial")]
        public SetorialEnum? Setorial { get; set; }

        [DisplayName("Unidade Externa")]
        public string? UnidadeExterna { get; set; }

        [DisplayName("Data inicial")]
        public DateTime DataInicial { get; set; }

        [DisplayName("Data final")]
        public DateTime DataFinal { get; set; }

        [DisplayName("Data de criação")]
        public DateTime DataCriacao { get; set; }
        public Guid AtividadeId { get; set; }
        public AtividadeViewModel? Atividade { get; set; }
        public string? TipoEventoTitulo { get; set; }
        public MesaEnum Mesa { get; set; }
    }
}