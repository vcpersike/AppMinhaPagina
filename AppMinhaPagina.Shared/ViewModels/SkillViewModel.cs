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
            if (_skills != value)
            {
                _skills = value;
                OnPropertyChanged(nameof(Skills));
            }
        }
    }

    public SkillViewModel(ISkillService skillService)
    {
        _skillService = skillService;
    }

    public async Task LoadSkillsAsync()
    {
        var skillsData = await _skillService.GetSkillsAsync();
        if (skillsData is not null && skillsData.Count > 0)
        {
            Skills = skillsData;
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
