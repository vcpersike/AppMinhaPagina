namespace AppMinhaPagina.Shared.ViewModels;

using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;



public class SkillViewModel : INotifyPropertyChanged
{
    private readonly ISkillService _skillService;

    private List<SkillModel> _skills = new();
    public List<SkillModel> Skills
    {
        get => _skills;
        set
        {
            _skills = value;
            OnPropertyChanged(nameof(Skills));
        }
    }

    public SkillViewModel(ISkillService skillService)
    {
        _skillService = skillService;
    }

    public async Task LoadSkillsAsync()
    {
        Skills = await _skillService.GetSkillsAsync();
        OnPropertyChanged(nameof(Skills));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
