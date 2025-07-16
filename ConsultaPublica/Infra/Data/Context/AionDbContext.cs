using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class AionDbContext : DbContext
{
    public AionDbContext(DbContextOptions<AionDbContext> options)
        : base(options) { }

    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Atividade> Atividades { get; set; }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Itemsatacollections> Itemsatacollections { get; set; }
    public DbSet<RelatorioEstatistico> RelatorioEstatistico { get; set; }
    public DbSet<TipoEvento> TiposEvento { get; set; }
    public DbSet<UnidadeGestora> UnidadesGestoras { get; set; }
    public DbSet<Pregoeiro> Pregoeiro { get; set; }
    public DbSet<ControleSubstituicao> ControleSubstituicao { get; set; }
    public DbSet<Contratos> Contratos { get; set; }
    public DbSet<Funcionario> Funcionario { get; set; }
    public DbSet<ControleFerias> ControleFerias { get; set; }
    public DbSet<Checklist> Checklists { get; set; }
    public DbSet<Anexo> Anexos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("Aion");

        builder
            .Entity<Anexo>()
            .HasOne(a => a.Atividade)
            .WithMany(at => at.Anexos)
            .HasForeignKey(a => a.AtividadeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
