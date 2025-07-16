using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Atividade
    {
        [Key]
        public Guid Id { get; set; }
        public virtual ICollection<RelatorioEstatistico> RelatoriosEstatisticos { get; set; } =
            new List<RelatorioEstatistico>();
        public string NumeroProcesso { get; set; } = string.Empty;
        public string? NumeroCertame { get; set; } = string.Empty;
        public string? IdPNCP { get; set; }
        public string Mesa { get; set; } = string.Empty; //Todas, quando não se define a mesa.
        public string Objeto { get; set; } = string.Empty;
        public string Legislacao { get; set; } = string.Empty; //14133/2023, quando não se define a legislação.
        public string Situacao { get; set; } = string.Empty; // Em andamento, quando não se define a situação.
        public string? Modalidade { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty; //Externo, quando não se define a localização.
        public string? MotivoRevogacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEntrada { get; set; }
        public int UnidadeGestoraId { get; set; }
        public virtual UnidadeGestora? UnidadeGestora { get; set; }
        public bool EstaNaMesa { get; set; }
        public bool Prioridade { get; set; }
        public bool EnfrentamentoCOVID { get; set; }
        public string? IdPrioridade { get; set; }
        public string? MotivoPrioridade { get; set; }
        public DateTime? DataPrevisao { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
        public DateTime? DataPrevisaoEmissao { get; set; }
        public DateTime? DataPrevisaoAssinatura { get; set; }
        public string? NaturezaDoObjeto { get; set; }
        public string ClasseObjeto { get; set; } = string.Empty;
        public int? ComplexidadeTecnica { get; set; }
        public int? NumeroItem { get; set; }
        public string? SubObjeto { get; set; }
        public string? ElementoDespesa { get; set; }
        public string? Justificativa { get; set; }
        public bool? IRP { get; set; }
        public string? NIRP { get; set; }
        public bool? ManifestacaoInteresse { get; set; }

        public string? FusoHorarioAbertura { get; set; }
        public bool EhPreCadastro { get; set; }
        public DateTime? DataConclusaoInterna { get; set; }
        public DateTime? DataConclusaoExterna { get; set; }
        public virtual ICollection<Anexo> Anexos { get; set; } = [];
    }
}
