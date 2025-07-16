using AgendaConsulta.Models;
using Domain.Entities;

namespace AgendaConsulta.Factories
{
    public static class TipoEventoFactory
    {
        public static TipoEvento TipoEventoViewModelParaEntity(TipoEventoViewModel viewModel)
        {
            var tipoEvento = new TipoEvento
            {
                Id = viewModel.Id,
                Titulo = viewModel.Titulo,
                Descricao = viewModel.Descricao
            };
            return tipoEvento;
        }

        public static TipoEventoViewModel EntityParaTipoEventoViewModel(TipoEvento entity)
        {
            var viewModel = new TipoEventoViewModel
            {
                Id = entity.Id,
                Titulo = entity.Titulo,
                Descricao = entity.Descricao
            };
            return viewModel;
        }

        public static List<TipoEventoViewModel> ListEntityParaListTipoEventoViewModel(
            IEnumerable<TipoEvento> entities
        )
        {
            var viewModels = new List<TipoEventoViewModel>();

            foreach (var entity in entities)
            {
                var viewModel = EntityParaTipoEventoViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }

        public static List<TipoEvento> ListTipoEventoViewModelParaListEntity(
            IEnumerable<TipoEventoViewModel> viewModels
        )
        {
            var entities = new List<TipoEvento>();

            foreach (var viewModel in viewModels)
            {
                var entity = TipoEventoViewModelParaEntity(viewModel);
                entities.Add(entity);
            }

            return entities;
        }
    }
}