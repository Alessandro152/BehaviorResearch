
using SearchForm.Domain;
using SearchForm.Models.ViewModels;

namespace SearchForm.Application.AppServices
{
    public class SearchFormAppServiceHandler
    {
        private readonly SearchFormDomain _searchFormDomain;

        public SearchFormAppServiceHandler(SearchFormDomain searchFormDomain)
        {
            _searchFormDomain = searchFormDomain;
        }

        internal bool VerificarCampos(GlobalViewModel dados)
        {
            return _searchFormDomain.ValidarCampos(dados);
        }

    }
}