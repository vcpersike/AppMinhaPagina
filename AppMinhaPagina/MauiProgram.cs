using AppMinhaPagina.Services;
using AppMinhaPagina.Shared.Services;
using AppMinhaPagina.Shared.Services.Interface;
using AppMinhaPagina.Shared.ViewModels;
using Microsoft.Extensions.Logging;

namespace AppMinhaPagina
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Add device-specific services used by the AppMinhaPagina.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            builder.Services.AddSingleton<IExperienceService, ExperienceService>();
            builder.Services.AddSingleton<IEducationService, EducationService>();

            builder.Services.AddTransient<ExperienceViewModel>();
            builder.Services.AddTransient<EducationViewModel>();
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
