using AgendaConsulta.Models;
using AgendaConsulta.ViewModels;
using Domain.DTOs;
using Domain.Entities;
using Domain.Enums;
using Infra.CrossCutting.Helpers;

namespace AgendaConsulta.Factories
{
    public static class AtividadeFactory
    {
        public static Atividade ProcessoAgendaToAtividade(ProcessoAgendaViewModel processoAgenda)
        {
            return new Atividade
            {
                NumeroProcesso = processoAgenda.NumeroProcesso,
                Mesa = MesaEnum.Todas.ToString(),
                Objeto = processoAgenda.Objeto,
                Legislacao = LegislacaoEnum.L14133.ToString(),
                Situacao = SituacaoAtividadeEnum.Andamento.ToString(),
                Localizacao = LocalizacaoEnum.Externo.ToString(),
                DataCriacao = DateTime.Now,
                DataConclusaoExterna = processoAgenda.DataConclusaoExterna,
                DataConclusaoInterna = processoAgenda.DataConclusaoInterna,
                DataPrevisaoEmissao = processoAgenda.DataPrevisao,
                ClasseObjeto = processoAgenda.ClasseObjeto.ToString()!,
                UnidadeGestoraId = processoAgenda.UnidadeGestoraId,
                Prioridade = processoAgenda.Prioridade,
                IdPrioridade = processoAgenda.IdPrioridade,
                MotivoPrioridade = processoAgenda.MotivoPrioridade,
                DataPrevisao = processoAgenda.DataPrevisao,
                SubObjeto = processoAgenda.Temas.ToString(),
                EhPreCadastro = true,
            };
        }

        public static Atividade AtividadeViewModelParaEntity(AtividadeViewModel viewModel)
        {
            var atividade = new Atividade
            {
                Id = viewModel.Id,
                NumeroProcesso = viewModel.NumeroProcesso,
                NumeroCertame = viewModel.NumeroCertame != null ? viewModel.NumeroCertame : "", //to-do - tratar corretamente
                Mesa = viewModel.Mesa.ToStringRepresentation(),
                Objeto = viewModel.Objeto,
                Legislacao = viewModel.Legislacao.ToStringRepresentation(),
                Modalidade = viewModel.Modalidade.ToStringRepresentation(),
                Situacao = viewModel.Situacao.ToStringRepresentation(),
                MotivoRevogacao = viewModel.MotivoRevogacao,
                Localizacao = viewModel.Localizacao.ToStringRepresentation(),
                DataEntrada = viewModel.DataEntrada,
                DataCriacao = viewModel.DataCriacao,
                UnidadeGestoraId = viewModel.UnidadeGestoraId,
                Prioridade = viewModel.Prioridade,
                IdPrioridade = viewModel.IdPrioridade,
                MotivoPrioridade = viewModel.MotivoPrioridade?.ToStringRepresentation(),
                DataPrevisao = viewModel.DataPrevisao,
                IdPNCP = viewModel.IdPNCP,
                //EstaNaMesa = viewModel.EstaNaMesa,
                //Eventos = viewModel.Eventos != null ? EventoFactory.ListEventoViewModelParaListEntity(viewModel.Eventos) : new List<Evento>()
            };
            return atividade;
        }

        public static AtividadeViewModel EntityParaAtividadeViewModel(Atividade entity)
        {
            var ultimoEvento = entity
                .Eventos?.OrderByDescending(e => e.DataInicial)
                .FirstOrDefault();

            return new AtividadeViewModel
            {
                Id = entity.Id,
                NumeroProcesso = entity.NumeroProcesso,
                NumeroCertame = entity.NumeroCertame,
                Mesa = entity.Mesa.ToEnumValue<MesaEnum>(),
                Objeto = entity.Objeto,
                Legislacao = entity.Legislacao.ToEnumValue<LegislacaoEnum>(),
                Situacao = entity.Situacao.ToEnumValue<SituacaoAtividadeEnum>(),
                MotivoRevogacao = entity.MotivoRevogacao,
                Modalidade = entity.Modalidade.ToEnumValue<ModalidadeEnum>(),
                Localizacao = entity.Localizacao.ToEnumValue<LocalizacaoEnum>(),
                DataEntrada = entity.DataEntrada ?? DateTime.Now,
                DataCriacao = entity.DataCriacao,
                UnidadeGestoraId = entity.UnidadeGestoraId,
                Prioridade = entity.Prioridade,
                IdPrioridade = entity.IdPrioridade,
                MotivoPrioridade = entity.MotivoPrioridade?.ToEnumValue<MotivoPrioridadeEnum>(),
                DataPrevisao = entity.DataPrevisao,
                DataPrevisaoAssinatura = entity.DataPrevisaoAssinatura,
                DataPrevisaoEmissao = entity.DataPrevisaoEmissao,
                IdPNCP = entity.IdPNCP,
                EstaNaMesa = entity.EstaNaMesa,
                UnidadeGestora =
                    entity.UnidadeGestora != null
                        ? UnidadeGestoraFactory.EntityParaUnidadeGestoraViewModel(
                            entity.UnidadeGestora
                        )
                        : new UnidadeGestoraViewModel(),
                Eventos =
                    entity.Eventos != null
                        ? EventoFactory.ListEntityParaListEventoViewModel(entity.Eventos)
                        : new List<EventoViewModel>(),
                UnidadesExternas = new List<UnidadeGestoraViewModel>(),
                UltimoEvento =
                    ultimoEvento != null
                        ? EventoFactory.EntityParaEventoViewModel(ultimoEvento)
                        : null,
            };
        }

        public static AtividadeViewModel AtividadeCardDtoParaAtividadeViewModel(
            AtividadeCardDto entity
        )
        {
            return new AtividadeViewModel
            {
                Id = entity.Id,
                NumeroProcesso = entity.NumeroProcesso,
                NumeroCertame = entity.NumeroCertame,
                Mesa = entity.Mesa.ToEnumValue<MesaEnum>(),
                Objeto = entity.Objeto,
                Legislacao = entity.Legislacao.ToEnumValue<LegislacaoEnum>(),
                Situacao = entity.Situacao.ToEnumValue<SituacaoAtividadeEnum>(),
                MotivoRevogacao = entity.MotivoRevogacao,
                Modalidade = entity.Modalidade.ToEnumValue<ModalidadeEnum>(),
                Localizacao = entity.Localizacao.ToEnumValue<LocalizacaoEnum>(),
                DataEntrada = entity.DataEntrada,
                DataCriacao = entity.DataEntrada,
                UnidadeGestoraId = entity.UnidadeGestoraId,
                Prioridade = entity.Prioridade,
                IdPrioridade = entity.IdPrioridade,
                MotivoPrioridade = entity.MotivoPrioridade?.ToEnumValue<MotivoPrioridadeEnum>(),
                DataPrevisao = entity.DataPrevisao,
                IdPNCP = entity.IdPNCP,
                EstaNaMesa = entity.EstaNaMesa,
                UnidadeGestora =
                    entity.UnidadeGestora != null
                        ? UnidadeGestoraFactory.EntityParaUnidadeGestoraViewModel(
                            entity.UnidadeGestora
                        )
                        : new UnidadeGestoraViewModel(),
                //UltimoEvento = entity.UltimoEvento != null ? EventoFactory.EventoDtoParaEventoViewModel(entity.UltimoEvento) : null,
            };
        }

        public static ProcessoAgendaViewModel EntityParaProcessoAgendaViewModel(
            ProcessoAgenda entity
        )
        {
            return new ProcessoAgendaViewModel
            {
                Id = entity.Id,
                NumeroProcesso = entity.NumeroProcesso,
                Objeto = entity.Objeto,
                Situacao = entity.Situacao.ToEnumValue<SituacaoAtividadeEnum>().GetDisplayName(),
                UnidadeGestoraId = entity.UnidadeGestoraId,
                Prioridade = entity.Prioridade,
                IdPrioridade = entity.IdPrioridade,
                MotivoPrioridade = entity
                    .MotivoPrioridade?.ToEnumValue<MotivoPrioridadeEnum>()
                    .ToString(),
                DataPrevisao = entity.DataPrevisao,
                DataConclusaoExterna = entity.DataConclusaoExterna,
                DataConclusaoInterna = entity.DataConclusaoInterna,
                Eventos =
                    entity.Eventos != null
                        ? EventoFactory.ListEntityParaListEventoViewModel(entity.Eventos)
                        : new List<EventoViewModel>()
            };
        }

        public static List<ProcessoAgendaViewModel> ListEntityParaListProcessoAgendaViewModel(
            IEnumerable<ProcessoAgenda> entities
        )
        {
            var viewModels = new List<ProcessoAgendaViewModel>();

            foreach (var entity in entities)
            {
                var viewModel = EntityParaProcessoAgendaViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }

        public static List<AtividadeViewModel> ListEntityParaListAtividadeViewModel(
            IEnumerable<Atividade> entities
        )
        {
            var viewModels = new List<AtividadeViewModel>();

            foreach (var entity in entities)
            {
                var viewModel = EntityParaAtividadeViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }

        public static List<AtividadeViewModel> ListAtividadeCardDtoParaListAtividadeViewModel(
            IEnumerable<AtividadeCardDto> entities
        )
        {
            var viewModels = new List<AtividadeViewModel>();

            foreach (var entity in entities)
            {
                var viewModel = AtividadeCardDtoParaAtividadeViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }

        public static ProcessoAgendaViewModel MontarViewModelComAion(
            ProcessoAgenda agenda,
            Atividade atividade
        )
        {
            var ultimoEvento = atividade
                .Eventos?.OrderByDescending(e => e.DataInicial)
                .FirstOrDefault();

            var Situacao = atividade.Situacao.ToEnumValue<SituacaoAtividadeEnum>();

            var viewModel = new ProcessoAgendaViewModel
            {
                Id = agenda.Id,
                NumeroProcesso = agenda.NumeroProcesso,
                UnidadeGestoraId = agenda.UnidadeGestoraId,
                Objeto = atividade.Objeto,
                Prioridade = atividade.Prioridade,
                IdPrioridade = atividade?.IdPrioridade,
                MotivoPrioridade = atividade
                    ?.MotivoPrioridade?.ToEnumValue<MotivoPrioridadeEnum>()
                    .ToString(),
                DataEntrada = atividade?.DataEntrada ?? DateTime.Now,
                DataCriacao = atividade?.DataCriacao ?? DateTime.Now,
                DataPrevisao = atividade?.DataPrevisao,
                Temas = atividade?.SubObjeto?.ToEnumValue<SubObjetoAtividadeEnum>(),
                Situacao = atividade.Situacao.ToEnumValue<SituacaoAtividadeEnum>().GetDisplayName(),
                Eventos =
                    atividade.Eventos != null
                        ? EventoFactory.ListEntityParaListEventoViewModel(atividade.Eventos)
                        : new List<EventoViewModel>(),
                UltimoEvento =
                    ultimoEvento != null
                        ? EventoFactory.EntityParaEventoViewModel(ultimoEvento)
                        : null
            };

            return viewModel;
        }

        public static ProcessoAgendaViewModel AtividadeToProcessoAgendaViewModel(
            Atividade atividade
        )
        {
            var ultimoEvento = atividade.Eventos?.OrderBy(e => e.DataInicial).FirstOrDefault();

            return new ProcessoAgendaViewModel
            {
                Id = atividade.Id,
                UnidadeGestoraId = atividade.UnidadeGestoraId,
                Objeto = atividade.Objeto,
                Prioridade = atividade.Prioridade,
                IdPrioridade = atividade?.IdPrioridade,
                MotivoPrioridade = atividade
                    ?.MotivoPrioridade?.ToEnumValue<MotivoPrioridadeEnum>()
                    .ToString(),
                DataEntrada = atividade?.DataEntrada ?? DateTime.Now,
                DataCriacao = atividade?.DataCriacao ?? DateTime.Now,
                DataPrevisao = atividade?.DataPrevisao,
                Temas = atividade?.SubObjeto?.ToEnumValue<SubObjetoAtividadeEnum>(),
                Situacao = atividade.Situacao.ToEnumValue<SituacaoAtividadeEnum>().GetDisplayName(),
                NumeroProcesso = atividade.NumeroProcesso,
                DataConclusaoExterna = atividade.DataConclusaoExterna,
                DataConclusaoInterna = atividade.DataConclusaoInterna,
                Mesa = atividade.Mesa,
                NumeroCertame = atividade.NumeroCertame,
                Eventos =
                    atividade.Eventos != null
                        ? EventoFactory.ListEntityParaListEventoViewModel(atividade.Eventos)
                        : new List<EventoViewModel>(),
                UltimoEvento = ultimoEvento != null
                        ? EventoFactory.EntityParaEventoViewModel(ultimoEvento)
                        : null,


            };
        }

        public static List<ProcessoAgendaViewModel> ListEntityParaListProcessoAgendaViewModel(
            IEnumerable<Atividade> entities
        )
        {
            var viewModels = new List<ProcessoAgendaViewModel>();

            foreach (var entity in entities)
            {
                var viewModel = AtividadeToProcessoAgendaViewModel(entity);
                viewModel.Progresso = ProgressoCalculoHelper.ProgressoCalculo(viewModel.UltimoEvento?.TipoEvento.Titulo).ToString();

                viewModels.Add(viewModel);
            }

            return viewModels;
        }
    }
}
