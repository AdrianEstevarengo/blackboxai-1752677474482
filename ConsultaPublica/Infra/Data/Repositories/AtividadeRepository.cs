using Domain.DTOs;
using Domain.Entities;
using Domain.Enums;
using Infra.Data.Context;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class AtividadeRepository : Repository<Atividade>, IAtividadeRepository
    {
        private readonly AionDbContext _aionContext;

        public AtividadeRepository(AionDbContext context)
            : base(context)
        {
            _aionContext = context;
        }

        public async Task<IEnumerable<Atividade>> BuscarAtividadesPorTermo(
            ConsultaDto consulta,
            string ug
        )
        {
            IQueryable<Atividade> query = _aionContext
                .Atividades.AsNoTracking()
                .Where(a => a.EhPreCadastro);

            // Filtro por Unidade Gestora (UG)
            if (ug != "SUPEL")
            {
                query = query.Where(a => a.UnidadeGestora!.Sigla == ug);
            }

            // Filtro adicional por UnidadeGestoraId, se informado no DTO
            if (consulta.UnidadeGestoraId.HasValue)
            {
                query = query.Where(a => a.UnidadeGestoraId == consulta.UnidadeGestoraId.Value);
            }

            query = query
                .Where(a =>
                    string.IsNullOrEmpty(consulta.PalavraChave)
                    || a.Objeto.Contains(consulta.PalavraChave)
                )
                .Where(a =>
                    string.IsNullOrEmpty(consulta.NumeroProcesso)
                    || a.NumeroProcesso.Contains(consulta.NumeroProcesso)
                )
                // Filtro por SubObjeto
                .Where(a =>
                    consulta.SubObjeto == null || a.SubObjeto == consulta.SubObjeto.ToString()
                )
                // Filtro por EOrgao
                .Where(a => consulta.EOrgao == null || a.SubObjeto == consulta.EOrgao.ToString())
                .Where(a => !consulta.DataInicial.HasValue || a.DataEntrada >= consulta.DataInicial)
                .Where(a => !consulta.DataFinal.HasValue || a.DataEntrada <= consulta.DataFinal);

            var atividades = await query.ToListAsync();

            var situacoesPermitidas = new List<string>();
            if (consulta.EmAndamento)
            {
                situacoesPermitidas.Add(SituacaoAtividadeEnum.Andamento.ToString());
            }
            if (consulta.Concluidos)
            {
                situacoesPermitidas.Add(SituacaoAtividadeEnum.Exito.ToString());
                situacoesPermitidas.Add(SituacaoAtividadeEnum.Finalizado_parcial.ToString());
            }
            if (consulta.Deserto)
            {
                situacoesPermitidas.Add(SituacaoAtividadeEnum.Deserto.ToString());
            }
            if (consulta.Revogado)
            {
                situacoesPermitidas.Add(SituacaoAtividadeEnum.Revogado.ToString());
            }
            if (consulta.Atrasados)
            {
                atividades = atividades
                    .Where(a =>
                        a.DataPrevisao < DateTime.Now
                        && (a.Situacao != SituacaoAtividadeEnum.Exito.ToString())
                    )
                    .ToList();
            }

            if (situacoesPermitidas.Any())
            {
                atividades = atividades
                    .Where(a => situacoesPermitidas.Contains(a.Situacao))
                    .ToList();
            }
            return atividades;
        }

        public async Task<IEnumerable<Atividade>> GetAtividadeByUGAsync(string ug)
        {
            IQueryable<Atividade> query = _aionContext
                .Atividades.AsNoTracking()
                .Where(a => a.EhPreCadastro);

            if (ug != "SUPEL")
            {
                query = query.Where(a => a.UnidadeGestora!.Sigla == ug);
            }

            // Aplicar ordenação e includes antes de executar
            query = query
                .OrderByDescending(a => a.DataEntrada)
                .Include(a => a.UnidadeGestora)
                .Include(a => a.Eventos)
                .ThenInclude(e => e.TipoEvento);

            // Executar a query e retornar o resultado
            return await query.ToListAsync();
        }

        public async Task<Atividade> GetByNumeroProcessoAsync(string numeroProcesso, string ug)
        {
            var atividade = await _aionContext
                .Atividades.AsNoTracking()
                 .Include(a => a.Eventos)
                .ThenInclude(e => e.TipoEvento)
                .Include(a => a.UnidadeGestora)
                .FirstOrDefaultAsync(a => a.NumeroProcesso == numeroProcesso);

            return atividade!;
        }

        public async Task<List<Atividade>> GetByNumerosProcessosAsync(
            List<string> numerosProcessos,
            string ug
        )
        {
            if (numerosProcessos == null || !numerosProcessos.Any())
            {
                return new List<Atividade>();
            }

            // Monta a lista de parâmetros para o IN
            var parametros = string.Join(", ", numerosProcessos.Select((n, i) => $"@p{i}"));
            var sql =
                $@"
                SELECT a.*
                FROM Aion.Atividades a
                INNER JOIN Aion.UnidadesGestoras ug ON a.UnidadeGestoraId = ug.Id
                WHERE a.NumeroProcesso IN ({parametros})
                {(ug != "SUPEL" ? "AND ug.Sigla = @ug" : "")}
            ";

            var sqlParams = numerosProcessos
                .Select((n, i) => new Microsoft.Data.SqlClient.SqlParameter($"@p{i}", n))
                .ToList();

            if (ug != "SUPEL")
            {
                sqlParams.Add(new Microsoft.Data.SqlClient.SqlParameter("@ug", ug));
            }

            // Inclui os relacionamentos manualmente após o raw query
            var atividades = await _aionContext
                .Atividades.FromSqlRaw(sql, sqlParams.ToArray())
                .Where(a => a.EhPreCadastro)
                .Include(a => a.UnidadeGestora)
                .Include(a => a.Eventos)
                .ThenInclude(e => e.TipoEvento)
                .ToListAsync();

            return atividades;
        }
    }
}
