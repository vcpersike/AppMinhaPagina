using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using AppMinhaPagina.Shared.Models;

namespace AppMinhaPagina.Shared.Components
{
    public partial class EducationCard
    {
        [Parameter] public List<Education> Educations { get; set; } = new();
    }
}
