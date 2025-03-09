using System.Collections.Generic;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;

namespace AppMinhaPagina.Shared.Services;

public class SkillService : ISkillService
{
    public async Task<List<SkillModel>> GetSkillsAsync()
    {
        await Task.Delay(500);
        return new List<SkillModel>
        {
            new SkillModel("C#", 60),
            new SkillModel("React", 80),
            new SkillModel("Blazor", 50),
            new SkillModel("Azure", 30)
        };
    }
}
