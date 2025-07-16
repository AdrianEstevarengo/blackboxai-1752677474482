using Domain.Entities;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IEventoRepository : IRepository<Evento>
    {
        Task<IEnumerable<Evento>> ConsultarEventosPorAtividadeId(Guid atividadeId);
    }
}
