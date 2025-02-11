using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services;

namespace AppMinhaPagina.Shared.ViewModels
{
    public class EducationViewModel
    {
        private readonly EducationService _educationService;
        public ObservableCollection<Education> Educations { get; private set; } = new();

        public EducationViewModel()
        {
            _educationService = new EducationService();
        }

        public async Task LoadEducationsAsync()
        {
            var educations = await _educationService.GetEducationsAsync();
            if (educations != null)
            {
                Educations.Clear();
                foreach (var edu in educations)
                {
                    Educations.Add(edu);
                }
            }
        }
    }
}
