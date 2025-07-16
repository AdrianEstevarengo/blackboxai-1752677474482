using System.Diagnostics;
using AgendaConsulta.Factories;
using AgendaConsulta.Models;
using Domain.Entities;
using Infra.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace AgendaConsulta.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IAtividadeRepository _atividadeRepository;
    private readonly IUnidadeGestoraRepository _unidadeGestoraRepository;

    public HomeController(
        ILogger<HomeController> logger,
        IAtividadeRepository atividadeRepository,
        IUnidadeGestoraRepository unidadeGestoraRepository
    )
    {
        _logger = logger;
        _atividadeRepository = atividadeRepository;
        _unidadeGestoraRepository = unidadeGestoraRepository;
    }

    public async Task<IActionResult> IndexAsync()
    {
        var orgao = User.FindFirst("Orgao")?.Value;

        var processosAgenda = await _atividadeRepository.GetAtividadeByUGAsync(orgao!);

        var viewModels = AtividadeFactory.ListEntityParaListProcessoAgendaViewModel(
            processosAgenda
        );

        var unidadesGestoras = await _unidadeGestoraRepository.GetAllUnidadeGestorasAsync();

        ViewBag.UnidadesGestoras = new SelectList(unidadesGestoras, "Id", "Sigla");
        ViewBag.AtividadesJson = JsonConvert.SerializeObject(viewModels);

        return View(viewModels);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
