using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;

public class ContactService : IContactService
{
    public async Task<ContactModel> GetContactAsync()
    {
        return new ContactModel
        {
            Email = "dev.victor.persike@gmail.com",
            Phone = "+55 11 95705-7466",
            Website = "https://victorpersike.dev.br"
        };
    }
}
