using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;
using Microsoft.Extensions.Logging;

public class ExperienceService : IExperienceService
{
    private readonly ILogger<ExperienceService> _logger;

    public ExperienceService(ILogger<ExperienceService> logger)
    {
        _logger = logger;
    }

    public async Task<List<ExperienceModel>> GetExperiencesAsync()
    {
        _logger.LogInformation("Chamando ExperienceService para buscar experiências...");

        return await Task.FromResult(new List<ExperienceModel>
        {
            new ExperienceModel { Role = "Desenvolvedor Full-Stack", Company = "Saúde One", Period = "07/22 - 04/23", Description = "Desenvolvimento de soluções para gestão médica." },
            new ExperienceModel { Role = "Desenvolvedor Mobile", Company = "TOTVS", Period = "07/23 - 02/24", Description = "Criação de apps híbridos com Ionic e Angular." }
        });
    }
}
