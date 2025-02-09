using Microsoft.AspNetCore.Components;

namespace AppMinhaPagina.Shared.Components
{
    public partial class SkillList : ComponentBase
    {
        public List<string> Skills { get; set; } = new()
        {
            "C#", "Angular", "React", "Docker", "Azure DevOps", "DDD", "SOLID", "GO", "Observabilidade"
        };
    }
}
