using BurgerOrdering.UI.Components.Pages;
using BurgerOrdering.UI.Services;
using BurgerOrdering.App.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<FileService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<AppState>();

var app = builder.Build();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();