using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgendaConsulta.Controllers
{
    public class AtendimentoController : Controller
    {
        private readonly AgendaDbContext _context;

        public AtendimentoController(AgendaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var atendentes = _context.Atendentes.ToList();
            return View(atendentes);
        }
    }
}
