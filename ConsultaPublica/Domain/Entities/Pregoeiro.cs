using Domain.Enums;

namespace Domain.Entities;

public class Pregoeiro
{
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public string? Matricula { get; set; }
    public TipoPregoeiro Tipo { get; set; }
    public bool Ativo { get; set; } = true;
}
