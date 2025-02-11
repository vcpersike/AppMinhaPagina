using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppMinhaPagina.Shared.Models;
using AppMinhaPagina.Shared.Services;

namespace AppMinhaPagina.Shared.ViewModels
{
    public class TextContentViewModel
    {
        private readonly TextContentService _textService;

        public ObservableCollection<TextContent> Texts { get; private set; } = new();

        public TextContentViewModel()
        {
            _textService = new TextContentService(); // Injeção futura pode ser usada aqui
        }

        public async Task LoadTextsAsync()
        {
            var response = await _textService.GetTextsAsync();
            if (response != null)
            {
                Texts.Clear();
                foreach (var text in response)
                {
                    Texts.Add(text);
                }
            }
        }
    }
}
