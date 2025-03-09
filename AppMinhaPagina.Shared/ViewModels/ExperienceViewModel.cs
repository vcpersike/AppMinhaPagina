namespace AppMinhaPagina.Shared.ViewModels;

using System.ComponentModel;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;
using Microsoft.Extensions.Logging;

public class ExperienceViewModel : INotifyPropertyChanged
{
    private readonly IExperienceService _experienceService;

    private List<ExperienceModel> _experiences;
    public List<ExperienceModel> Experiences
    {
        get => _experiences;
        set { _experiences = value; OnPropertyChanged(nameof(Experiences)); }
    }

    public ExperienceViewModel(IExperienceService experienceService)
    {
        _experienceService = experienceService;
        LoadExperiences();
    }

    public async void LoadExperiences()
    {
        Experiences = await _experienceService.GetExperiencesAsync();
        OnPropertyChanged(nameof(Experiences));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
