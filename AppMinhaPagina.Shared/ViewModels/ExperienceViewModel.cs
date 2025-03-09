namespace AppMinhaPagina.Shared.ViewModels;

using System.ComponentModel;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;
using System.Threading.Tasks;

public class ExperienceViewModel : INotifyPropertyChanged
{
    private readonly IExperienceService _experienceService;

    private List<ExperienceModel> _experiences = new();
    public List<ExperienceModel> Experiences
    {
        get => _experiences;
        set
        {
            if (_experiences != value)
            {
                _experiences = value;
                OnPropertyChanged(nameof(Experiences));
            }
        }
    }

    public ExperienceViewModel(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    public async Task LoadExperiencesAsync()
    {
        var data = await _experienceService.GetExperiencesAsync();
        if (data is not null && data.Count > 0)
        {
            Experiences = data;
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
