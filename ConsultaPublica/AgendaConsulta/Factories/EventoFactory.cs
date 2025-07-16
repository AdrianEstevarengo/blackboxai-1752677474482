using Domain.DTOs;
using Domain.Enums;

using Infra.CrossCutting.Helpers;
using Domain.Entities;
using AgendaConsulta.Models;

namespace AgendaConsulta.Factories
{
    public class EventoFactory
    {
        public static Evento EventoViewModelParaEntity(EventoViewModel viewModel)
        {
            var evento = new Evento
            {
                Id = viewModel.Id,
                TipoEventoId = viewModel.TipoEventoId,
                Localizacao = viewModel.Localizacao?.ToStringRepresentation(),
                Setorial = viewModel.Setorial?.ToStringRepresentation(),
                DataInicial = viewModel.DataInicial,
                DataFinal = viewModel.DataFinal,
                DataCriacao = viewModel.DataCriacao,
                AtividadeId = viewModel.AtividadeId
            };
            return evento;
        }

        public static EventoViewModel EntityParaEventoViewModel(Evento entity)
        {
            var viewModel = new EventoViewModel
            {
                Id = entity.Id,
                TipoEventoId = entity.TipoEventoId,
                Localizacao = entity.Localizacao?.ToEnumValue<LocalizacaoEnum>(),
                Setorial = entity.Setorial?.ToEnumValue<SetorialEnum>(),
                DataInicial = entity.DataInicial,
                DataFinal = entity.DataFinal,
                DataCriacao = entity.DataCriacao,
                AtividadeId = entity.AtividadeId,
                TipoEvento = TipoEventoFactory.EntityParaTipoEventoViewModel(entity.TipoEvento!)
            };
            return viewModel;
        }
        public static EventoViewModel EventoDtoParaEventoViewModel(EventoDto entity)
        {
            var viewModel = new EventoViewModel
            {
                TipoEventoId = entity.TipoEventoId,
                DataInicial = entity.DataInicial,
                DataFinal = entity.DataFinal,
                DataCriacao = entity.DataCriacao,
                TipoEventoTitulo = entity.TipoEventoTitulo,
            };
            return viewModel;
        }
        public static List<EventoViewModel> ListEntityParaListEventoViewModel(
            IEnumerable<Evento> entities
        )
        {
            var viewModels = new List<EventoViewModel>();

            foreach (var entity in entities)
            {
                var viewModel = EntityParaEventoViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }

        public static List<Evento> ListEventoViewModelParaListEntity(
            IEnumerable<EventoViewModel> viewModels
        )
        {
            var entities = new List<Evento>();

            foreach (var viewModel in viewModels)
            {
                var entity = EventoViewModelParaEntity(viewModel);
                entities.Add(entity);
            }

            return entities;
        }
    }
}