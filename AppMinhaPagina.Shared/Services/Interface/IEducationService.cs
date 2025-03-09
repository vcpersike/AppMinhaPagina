using AppMinhaPagina.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMinhaPagina.Shared.Services.Interface
{
    public interface IEducationService
    {
        Task<List<EducationModel>> GetEducationAsync();
    }

}
