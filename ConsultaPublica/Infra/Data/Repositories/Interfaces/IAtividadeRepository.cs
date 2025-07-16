using Domain.DTOs;
using Domain.Entities;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IAtividadeRepository : IRepository<Atividade>
    {
        Task<IEnumerable<Atividade>> BuscarAtividadesPorTermo(ConsultaDto consulta, string ug);
        Task<IEnumerable<Atividade>> GetAtividadeByUGAsync(string ug);

        Task<Atividade> GetByNumeroProcessoAsync(string numeroProcesso, string ug);
        Task<List<Atividade>> GetByNumerosProcessosAsync(List<string> numerosProcessos, string ug);
    }
}
