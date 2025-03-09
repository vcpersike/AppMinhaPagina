namespace AppMinhaPagina.Shared.ViewModels;

using System.ComponentModel;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;
using Microsoft.Extensions.Logging;

public class EducationViewModel : INotifyPropertyChanged
{
    private readonly IEducationService _educationService;

    private List<EducationModel> _educationList = new();
    public List<EducationModel> EducationList
    {
        get => _educationList;
        set
        {
            if (_educationList != value)
            {
                _educationList = value;
                OnPropertyChanged(nameof(EducationList));
            }
        }
    }

    public EducationViewModel(IEducationService educationService)
    {
        _educationService = educationService;
    }

    public async Task LoadEducationAsync()
    {
        var data = await _educationService.GetEducationAsync();
        if (data is not null && data.Count > 0)
        {
            EducationList = data;
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
