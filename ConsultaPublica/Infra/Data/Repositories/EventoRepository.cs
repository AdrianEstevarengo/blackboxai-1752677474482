using Domain.Entities;
using Infra.Data.Context;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class EventoRepository : Repository<Evento>, IEventoRepository
    {
        private readonly AionDbContext _aionContext;

        public EventoRepository(AionDbContext context) : base(context)
        {
            _aionContext = context;
        }

        public async Task<IEnumerable<Evento>> ConsultarEventosPorAtividadeId(Guid atividadeId)
        {
            var eventos = await _aionContext
                .Eventos.AsNoTracking()
                .Where(e => e.AtividadeId == atividadeId)
                .ToListAsync();

            return eventos;
        }
    }
}
