using System.Collections.Generic;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;

namespace AppMinhaPagina.Shared.Services
{
    public class TextContentService
    {
        public async Task<List<TextContent>> GetTextsAsync()
        {
            await Task.Delay(500); // Simula um pequeno delay de rede

            return new List<TextContent>
            {
                new TextContent { Title = "Bem-vindo ao App", Body = "Este é um exemplo de texto vindo do backend mockado." },
                new TextContent { Title = "Sobre Nós", Body = "Somos uma equipe dedicada ao desenvolvimento de soluções inovadoras." }
            };
        }
    }
}
