using AgendaConsulta.Models;

using Domain.Entities;

namespace AgendaConsulta.Factories
{
    public class UnidadeGestoraFactory
    {
        public static UnidadeGestora UnidadeGestoraViewModelParaEntity(
            UnidadeGestoraViewModel viewModel
        )
        {
            var unidadeGestora = new UnidadeGestora
            {
                Id = viewModel.Id,
                Nome = viewModel.Nome,
                Sigla = viewModel.Sigla
            };
            return unidadeGestora;
        }

        public static UnidadeGestoraViewModel EntityParaUnidadeGestoraViewModel(
            UnidadeGestora entity
        )
        {
            var viewModel = new UnidadeGestoraViewModel
            {
                Id = entity.Id,
                Nome = entity.Nome!,
                Sigla = entity.Sigla!
            };
            return viewModel;
        }

        public static List<UnidadeGestoraViewModel> ListEntityParaListUnidadeGestoraViewModel(
            IEnumerable<UnidadeGestora> entities
        )
        {
            var viewModels = new List<UnidadeGestoraViewModel>();

            foreach (var entity in entities)
            {
                var viewModel = EntityParaUnidadeGestoraViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }

        public static List<UnidadeGestora> ListUnidadeGestoraViewModelParaListEntity(
            IEnumerable<UnidadeGestoraViewModel> viewModels
        )
        {
            var entities = new List<UnidadeGestora>();

            foreach (var viewModel in viewModels)
            {
                var entity = UnidadeGestoraViewModelParaEntity(viewModel);
                entities.Add(entity);
            }

            return entities;
        }
    }
}