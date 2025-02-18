using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.ViewModels;

namespace AppMinhaPagina.Shared.Pages
{
    public partial class Home
    {
        private ExperienceViewModel ExperienceVM = new ExperienceViewModel();
        private EducationViewModel EducationVM = new EducationViewModel();
        private TextContentViewModel TextVM = new TextContentViewModel();

        protected override async Task OnInitializedAsync()
        {
            await ExperienceVM.LoadExperiencesAsync();
            await EducationVM.LoadEducationsAsync();
            await TextVM.LoadTextsAsync();
        }
    }
}
