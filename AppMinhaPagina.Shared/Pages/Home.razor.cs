using Microsoft.AspNetCore.Components;
using AppMinhaPagina.Shared.Models;

namespace AppMinhaPagina.Shared.Pages
{
    public partial class Home : ComponentBase
    {
        public List<Experience> MyExperiences { get; set; } = new()
        {
            new Experience
            {
                Empresa = "Ingram Micro",
                Cargo = "Desenvolvedor Full-Stack",
                Periodo = "10/23 - Atual",
                Descricao = "Será Atuo na squad de contabilidade, desenvolvendo soluções em C#, React e Azure."
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
