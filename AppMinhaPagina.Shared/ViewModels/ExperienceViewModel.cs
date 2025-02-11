using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services;

namespace AppMinhaPagina.Shared.ViewModels
{
    public class ExperienceViewModel
    {
        private readonly ExperienceService _experienceService;
        public ObservableCollection<Experience> Experiences { get; private set; } = new();

        public ExperienceViewModel()
        {
            _experienceService = new ExperienceService(); // Dependência pode ser injetada futuramente
        }

        public async Task LoadExperiencesAsync()
        {
            var experiences = await _experienceService.GetExperiencesAsync();
            if (experiences != null)
            {
                Experiences.Clear();
                foreach (var exp in experiences)
                {
                    Experiences.Add(exp);
                }
            }
        }
    }
}
