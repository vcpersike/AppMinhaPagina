using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using AppMinhaPagina.Shared.Models;

namespace AppMinhaPagina.Shared.Components
{
    public partial class ExperienceCard
    {
        [Parameter] public List<Experience> Experiences { get; set; } = new();
    }
}
