using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.ViewModels;

namespace AppMinhaPagina.Shared.Pages
{
    public partial class Home
    {
        private ExperienceViewModel ExperienceVM = new ExperienceViewModel();
        private TextContentViewModel TextVM = new TextContentViewModel();
        private EducationViewModel EducationVM = new EducationViewModel();

        protected override async Task OnInitializedAsync()
        {
            await ExperienceVM.LoadExperiencesAsync();
            await TextVM.LoadTextsAsync();
            await EducationVM.LoadEducationsAsync();
        }
    }
}
