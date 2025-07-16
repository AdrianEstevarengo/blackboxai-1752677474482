using AgendaConsulta.Factories;
using AgendaConsulta.Models;
using Domain.DTOs;
using Domain.Entities;
using Domain.Enums;
using Infra.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

[Authorize]
public class AtividadeController : Controller
{
    private readonly IAtividadeRepository _atividadeRepository;
    private readonly IUnidadeGestoraRepository _unidadeGestoraRepository;

    public AtividadeController(
        IAtividadeRepository atividadeRepository,
        IUnidadeGestoraRepository unidadeGestoraRepository
    )
    {
        _atividadeRepository = atividadeRepository;
        _unidadeGestoraRepository = unidadeGestoraRepository;
    }

    public async Task<ActionResult> CreateAsync()
    {
        var unidadesGestoras = await _unidadeGestoraRepository.GetAllUnidadeGestorasAsync();
        ViewBag.UnidadesGestoras = new SelectList(unidadesGestoras, "Id", "Sigla");
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> CreateAsync(ProcessoAgendaViewModel viewModel)
    {
        var unidadesGestoras = await _unidadeGestoraRepository.GetAllUnidadeGestorasAsync();

        if (ModelState.IsValid)
        {
            // Obter o valor do �rg�o do usu�rio logado
            var orgao = User.FindFirst("Orgao")?.Value;

            if (string.IsNullOrEmpty(viewModel.Situacao))
            {
                viewModel.Situacao = SituacaoAtividadeEnum.Andamento.ToString();
            }

            // Verificar se o NumeroProcesso j� existe
            var existeAtividade = await _atividadeRepository.GetByNumeroProcessoAsync(
                viewModel.NumeroProcesso!,
                orgao!
            );

            bool deveAtualizar = false;

            if (existeAtividade != null)
            {
                // Valida se é pré-cadastro (prioridade maior)
                if (existeAtividade.EhPreCadastro)
                {
                    ModelState.AddModelError("NumeroProcesso", "Número de Processo já cadastrado");
                    ViewBag.UnidadesGestoras = new SelectList(unidadesGestoras, "Id", "Sigla");
                    return View(viewModel);
                }

                // Valida se pertence à mesma unidade gestora
                if (existeAtividade.UnidadeGestoraId != viewModel.UnidadeGestoraId)
                {
                    ModelState.AddModelError(
                        "NumeroProcesso",
                        "Número de Processo já cadastrado para outra unidade gestora."
                    );
                    ViewBag.UnidadesGestoras = new SelectList(unidadesGestoras, "Id", "Sigla");
                    return View(viewModel);
                }

                // Se chegou até aqui, deve atualizar o registro existente
                deveAtualizar = true;
            }

            // Continua o processamento normal...
            if (deveAtualizar)
            {
                existeAtividade!.Objeto = viewModel.Objeto;
                existeAtividade!.ClasseObjeto = viewModel.ClasseObjeto.ToString()!;
                existeAtividade!.DataPrevisao = viewModel.DataPrevisao;
                existeAtividade!.DataConclusaoExterna = viewModel.DataConclusaoExterna;
                existeAtividade!.DataConclusaoInterna = viewModel.DataConclusaoInterna;
                existeAtividade!.SubObjeto = viewModel.Temas.ToString();
                existeAtividade!.EhPreCadastro = true;

                await _atividadeRepository.UpdateAsync(existeAtividade);
                await _atividadeRepository.SaveAsync();
            }
            else
            {
                Atividade consultaAtividade = AtividadeFactory.ProcessoAgendaToAtividade(viewModel);

                await _atividadeRepository.InsertAsync(consultaAtividade);
                await _atividadeRepository.SaveAsync();
            }

            ViewBag.UnidadesGestoras = new SelectList(unidadesGestoras, "Id", "Sigla");
            return RedirectToAction("Create", "Atividade");
        }
        return View(viewModel);
    }

    [HttpPost]
    public async Task<List<Atividade>> BuscarProcessos(ConsultaDto consulta)
    {
        try
        {
            if (!consulta.ValidarDatas())
            {
                return new List<Atividade>();
            }

            var orgao = User.FindFirst("Orgao")?.Value;
            var atividades = await _atividadeRepository.BuscarAtividadesPorTermo(consulta, orgao!);

            return atividades.ToList();
        }
        catch
        {
            throw;
        }
    }

    public async Task<IActionResult> IndexAsync()
    {
        var orgao = User.FindFirst("Orgao")?.Value;
        var atividades = await _atividadeRepository.GetAtividadeByUGAsync(orgao!);

        var atividadeViewModel = AtividadeFactory.ListEntityParaListProcessoAgendaViewModel(
            atividades
        );
        var unidadesGestoras = await _unidadeGestoraRepository.GetAllUnidadeGestorasAsync();

        var settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        ViewBag.UnidadesGestoras = new SelectList(unidadesGestoras, "Id", "Sigla");
        ViewBag.AtividadesJson = JsonConvert.SerializeObject(atividades, settings);

        return View(atividadeViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> CarregarConteudoDinamico(string atividadesJson)
    {
        try
        {
            var atividades = JsonConvert.DeserializeObject<List<ProcessoAgenda>>(
                atividadesJson ?? "[]"
            );
            var atividadeViewModel = AtividadeFactory.ListEntityParaListProcessoAgendaViewModel(
                atividades
            );

            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            ViewBag.AtividadesJson = JsonConvert.SerializeObject(atividades, settings);
            return PartialView("_ConteudoDinamico", atividadeViewModel);
        }
        catch
        {
            return PartialView("_ConteudoDinamico", new List<ProcessoAgendaViewModel>());
        }
    }
}
