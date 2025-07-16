using Domain.Entities;
using Infra.Data.Context;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class UnidadeGestoraRepository : Repository<UnidadeGestora>, IUnidadeGestoraRepository
    {
        private readonly AionDbContext _aionContext;

        public UnidadeGestoraRepository(AionDbContext context) : base(context)
        {
            _aionContext = context;
        }

        public async Task<IEnumerable<UnidadeGestora>> GetAllUnidadeGestorasAsync()
        {
            return await _aionContext.UnidadesGestoras.OrderBy(u => u.Sigla).ToListAsync();
        }

        public async Task<UnidadeGestora?> GetBySiglaAsync(string sigla)
        {
            return await _aionContext
                .UnidadesGestoras.Where(u =>
                    u.Sigla!.Equals(sigla, StringComparison.CurrentCultureIgnoreCase)
                )
                .FirstAsync();
        }
    }
}
