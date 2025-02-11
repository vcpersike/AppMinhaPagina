using System.Collections.Generic;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;

namespace AppMinhaPagina.Shared.Services
{
    public class ExperienceService
    {
        public async Task<List<Experience>> GetExperiencesAsync()
        {
            await Task.Delay(500); // Simula um pequeno delay de rede

            return new List<Experience>
            {
                new Experience
                {
                    Empresa = "Ingram Micro",
                    Cargo = "Desenvolvedor Full-Stack",
                    Periodo = "10/23 - Atual",
                    Descricao = "Atuo na squad de contabilidade, desenvolvendo soluções em C#, React e Azure."
                },
                new Experience
                {
                    Empresa = "Totvs Meu Protheus",
                    Cargo = "Desenvolvedor Mobile",
                    Periodo = "07/23 - 02/24",
                    Descricao = "Desenvolvimento de apps móveis com Angular 15 e Ionic, integrando Firebase."
                }
            };
        }
    }
}
