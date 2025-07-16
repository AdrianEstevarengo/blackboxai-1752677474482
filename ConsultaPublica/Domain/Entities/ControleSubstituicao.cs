using Domain.Enums;

namespace Domain.Entities;

public class ControleSubstituicao
{
    public Guid Id { get; set; }
    public Guid PregoeiroId { get; set; }
    public Pregoeiro? Pregoeiro { get; set; }
    public Guid PregoeiroSubstitutoId { get; set; }
    public Pregoeiro? PregoeiroSubstituto { get; set; }
    public string? PregoeiroNome { get; set; }
    public string? PregoeiroSubstitutoNome { get; set; }
    public MotivoSubstituicao Motivo { get; set; }
    public int Periodo { get; set; }
    public PagamentoSubstituicao Pagamento { get; set; }
    public DateTime DataInicial { get; set; }
    public DateTime DataFinal { get; set; }
}
