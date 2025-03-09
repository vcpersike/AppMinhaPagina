using AppMinhaPagina.Shared.Services;
using AppMinhaPagina.Shared.Services.Interface;
using AppMinhaPagina.Shared.ViewModels;
using AppMinhaPagina.Web.Components;
using AppMinhaPagina.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IFormFactor, FormFactor>();
builder.Services.AddSingleton<IExperienceService, ExperienceService>();
builder.Services.AddSingleton<IEducationService, EducationService>();

builder.Services.AddTransient<ExperienceViewModel>();
builder.Services.AddTransient<EducationViewModel>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(AppMinhaPagina.Shared._Imports).Assembly);

app.Run();
