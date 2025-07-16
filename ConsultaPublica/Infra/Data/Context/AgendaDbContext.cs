using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class AgendaDbContext : DbContext
{
    public AgendaDbContext(DbContextOptions<AgendaDbContext> options)
        : base(options) { }

    public DbSet<Atendente> Atendentes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("AgendaConsulta");
    }
}
