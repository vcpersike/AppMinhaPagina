using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;
using Microsoft.Extensions.Logging;

public class EducationService : IEducationService
{
    private readonly ILogger<EducationService> _logger;

    public EducationService(ILogger<EducationService> logger)
    {
        _logger = logger;
    }

    public async Task<List<EducationModel>> GetEducationAsync()
    {
        _logger.LogInformation("Chamando EducationService para buscar formações...");

        return await Task.FromResult(new List<EducationModel>
        {
            new EducationModel { Institution = "Faculdade Descomplica", Course = "Ciências da Computação", Period = "2022 - 2026" },
            new EducationModel { Institution = "RecodePro", Course = "Programação FullStack", Period = "2021 - 2022" }
        });
    }
}
