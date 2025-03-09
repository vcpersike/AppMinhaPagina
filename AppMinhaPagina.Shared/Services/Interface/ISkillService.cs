using System.Collections.Generic;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;

namespace AppMinhaPagina.Shared.Services.Interface;

public interface ISkillService
{
    Task<List<SkillModel>> GetSkillsAsync();
}
