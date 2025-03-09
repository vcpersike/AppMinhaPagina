namespace AppMinhaPagina.Shared.ViewModels;

using System.ComponentModel;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;
using System.Threading.Tasks;

public class ContactViewModel : INotifyPropertyChanged
{
    private readonly IContactService _contactService;

    private ContactModel _contact = new();
    public ContactModel Contact
    {
        get => _contact;
        set
        {
            if (_contact != value)
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }
    }

    public ContactViewModel(IContactService contactService)
    {
        _contactService = contactService;
    }

    public async Task LoadContactAsync()
    {
        Contact = await _contactService.GetContactAsync();
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
