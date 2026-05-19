using FerreteriaApp.Components;
using FerreteriaApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Registro del contexto de la base de datos
builder.Services.AddDbContext<FerreteriaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Servicios para los componentes de Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// 3. Configuración del pipeline de solicitudes HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// 4. Mapeo de componentes de Blazor
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// 5. Puerto seguro para evitar bloqueos del sistema
app.Urls.Add("http://localhost:5100");

app.Run();