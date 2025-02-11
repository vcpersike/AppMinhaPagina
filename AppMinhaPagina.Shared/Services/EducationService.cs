using System.Collections.Generic;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;

namespace AppMinhaPagina.Shared.Services
{
    public class EducationService
    {
        public async Task<List<Education>> GetEducationsAsync()
        {
            await Task.Delay(500); // Simula um pequeno delay de rede

            return new List<Education>
            {
                new Education
                {
                    Instituicao = "Faculdade Descomplica",
                    Curso = "Ciências da Computação",
                    Periodo = "2022 - 2026",
                    Descricao = "Curso EAD voltado para desenvolvimento Full-Stack."
                },
                new Education
                {
                    Instituicao = "RecodePro",
                    Curso = "Programação FullStack",
                    Periodo = "2021 - 2022",
                    Descricao = "Curso intensivo de 520 horas sobre desenvolvimento Full-Stack."
                }
            };
        }
    }
}
