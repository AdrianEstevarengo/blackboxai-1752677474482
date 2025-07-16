using System.ComponentModel.DataAnnotations;
using AgendaConsulta.Models;
using Domain.Enums;

namespace AgendaConsulta.ViewModels
{
    public class AtividadeViewModel
    {
        public AtividadeViewModel()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
            Eventos = new List<EventoViewModel>();
        }

        public Guid Id { get; set; }

        [Display(Name = "Número do Processo")]
        public string NumeroProcesso { get; set; } = string.Empty;

        [Display(Name = "Número do Certame")]
        public string? NumeroCertame { get; set; }

        [Display(Name = "ID PNCP")]
        public string? IdPNCP { get; set; }

        [Display(Name = "Mesa")]
        public MesaEnum Mesa { get; set; }

        [Display(Name = "Localização")]
        public LocalizacaoEnum Localizacao { get; set; }

        [Display(Name = "Modalidade")]
        public ModalidadeEnum Modalidade { get; set; }

        [Display(Name = "Previsão Emissão OS")]
        [DataType(DataType.Date)]
        public DateTime? DataPrevisaoEmissao { get; set; }

        [Display(Name = "Previsão Assinatura do Contrato")]
        [DataType(DataType.Date)]
        public DateTime? DataPrevisaoAssinatura { get; set; }

        [Display(Name = "Número de Itens")]
        public int? NumeroItem { get; set; }

        [Display(Name = "Natureza do Objeto")]
        public string? NaturezaDoObjeto { get; set; }

        [Display(Name = "Elemento Despesa")]
        public string? ElementoDespesa { get; set; }

        [Display(Name = "Justificativa da Licitação")]
        public string? Justificativa { get; set; }

        [Display(Name = "Objeto")]
        public string Objeto { get; set; } = string.Empty;

        [Display(Name = "Legislação")]
        public LegislacaoEnum Legislacao { get; set; }

        [Display(Name = "Situação")]
        public SituacaoAtividadeEnum Situacao { get; set; }

        [Display(Name = "Motivo da Movimentação")]
        public string? MotivoRevogacao { get; set; }

        [Display(Name = "Data de Criação")]
        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data de Entrada")]
        [DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }

        [Display(Name = "Fuso Horário da Abertura")]
        public FusoHorarioEnum FusoHorarioAbertura { get; set; }

        [Display(Name = "Unidade Gestora")]
        public int UnidadeGestoraId { get; set; }

        [Display(Name = "Unidade Gestora")]
        public UnidadeGestoraViewModel UnidadeGestora { get; set; } = new UnidadeGestoraViewModel();

        public bool Prioridade { get; set; }

        [Display(Name = "ID. Prioridade")]
        public string? IdPrioridade { get; set; }

        [Display(Name = "Motivo da Prioridade")]
        public MotivoPrioridadeEnum? MotivoPrioridade { get; set; }

        [Display(Name = "Data de Previsão")]
        [DataType(DataType.Date)]
        public DateTime? DataPrevisao { get; set; }
        public EventoViewModel? UltimoEvento { get; set; }
        public ICollection<EventoViewModel>? Eventos { get; set; }
        public bool EstaNaMesa { get; set; }
        public List<UnidadeGestoraViewModel> UnidadesExternas { get; set; } =
            new List<UnidadeGestoraViewModel>();

        [Display(Name = "Setorial")]
        public SetorialEnum? Setorial { get; set; }
        public int TotalDias { get; set; }
        public int DiasInternos { get; set; }
        public int DiasExternos { get; set; }
        public DateTime? DataAberturaCertame { get; internal set; }

        [Display(Name = "Subobjetos")]
        public SubObjetoAtividadeEnum? SubObjeto { get; set; }

        public bool? IRP { get; set; }

        [Display(Name = "N.º IRP")]
        public string? NIRP { get; set; }

        [Display(Name = "Manifestação De Interesse")]
        public bool? ManifestacaoInteresse { get; set; }

        [Display(Name = "Enfrentamento ao COVID-19")]
        public bool EnfrentamentoCovid { get; set; }
    }
}
