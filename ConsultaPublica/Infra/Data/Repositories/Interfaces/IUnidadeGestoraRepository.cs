using Domain.Entities;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IUnidadeGestoraRepository : IRepository<UnidadeGestora>
    {
        Task<UnidadeGestora?> GetBySiglaAsync(string sigla);
        Task<IEnumerable<UnidadeGestora>> GetAllUnidadeGestorasAsync();
    }
}
