namespace AppMinhaPagina.Shared.Services;

using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services.Interface;
using System.Threading.Tasks;

public class ContactService : IContactService
{
    public async Task<ContactModel> GetContactAsync()
    {
        // Simulando um carregamento assíncrono
        await Task.Delay(100);

        return new ContactModel
        {
            Email = "dev.victor.persike@gmail.com",
            Phone = "+55 11 95705-7466",
            Website = "https://www.victorpersike.dev.br"
        };
    }
}
