using AgendaConsulta.Services;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Infra.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configurationRoot = builder.Configuration;
var connectionString =
    configurationRoot.GetConnectionString("AionContextConnection")
    ?? throw new InvalidOperationException("Connection string 'AionContextConnection' not found.");

builder.Services.AddDbContext<AgendaDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDbContext<AionDbContext>(options => options.UseSqlServer(connectionString));

// Configuração de autenticação via Cookies
builder
    .Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/Login";
        options.LogoutPath = "/Auth/Logout";
        options.AccessDeniedPath = "/Home/AcessoNegado";
    });

builder.Services.AddAuthorization();

// Adicionando Configuração Singleton
builder.Services.AddSingleton(builder.Configuration);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<LDAPService>();
builder.Services.AddScoped<IAtividadeRepository, AtividadeRepository>();
builder.Services.AddScoped<IUnidadeGestoraRepository, UnidadeGestoraRepository>();

// Add SignalR service
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Map SignalR hub endpoint
app.MapHub<AgendaConsulta.Hubs.ChatHub>("/chatHub");

app.Run();
