using System.Security.Claims;
using AgendaConsulta.Services;
using Infra.Data.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AgendaConsulta.Controllers
{
    public class AuthController : Controller
    {
        private readonly LDAPService _ldapService;
        private readonly AgendaDbContext _context;

        public AuthController(LDAPService ldapService, AgendaDbContext context)
        {
            _ldapService = ldapService;
            _context = context;
        }

        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(string CPF, string password)
        {
            var Cpf = CPF.Replace(".", "").Replace("-", "");
            var (isAuthenticated, givenName, surname, orgao) = _ldapService.Authenticate(
                Cpf,
                password
            );

            if (!isAuthenticated)
            {
                ModelState.AddModelError("", "Usuário ou senha inválidos.");
                return View();
            }
            bool isAtendente = _context.Atendentes.Any(a => a.CPF == Cpf);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, CPF),
                new Claim(ClaimTypes.GivenName, givenName),
                new Claim(ClaimTypes.Surname, surname),
                new Claim("Orgao", orgao),
                new Claim("Perfil", isAtendente ? "Atendente" : "Usuário")
            };

            var identity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal
            );

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth"); // Redireciona para a tela de login
        }
    }
}
