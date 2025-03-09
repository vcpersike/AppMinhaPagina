namespace AppMinhaPagina.Shared.Services.Interface;

using AppMinhaPagina.Shared.Models;
using System.Threading.Tasks;

public interface IContactService
{
    Task<ContactModel> GetContactAsync();
}
