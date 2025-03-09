namespace AppMinhaPagina.Shared.ViewModels;

using System.ComponentModel;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;
using Microsoft.Extensions.Logging;

public class EducationViewModel : INotifyPropertyChanged
{
    private readonly IEducationService _educationService;

    private List<EducationModel> _educationList;
    public List<EducationModel> EducationList
    {
        get => _educationList;
        set { _educationList = value; OnPropertyChanged(nameof(EducationList)); }
    }

    public EducationViewModel(IEducationService educationService)
    {
        _educationService = educationService;
        LoadEducation();
    }

    public async void LoadEducation()
    {
        EducationList = await _educationService.GetEducationAsync();
        OnPropertyChanged(nameof(EducationList));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

