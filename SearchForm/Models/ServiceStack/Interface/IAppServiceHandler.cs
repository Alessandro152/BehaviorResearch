
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;

namespace SearchForm.Models.ServiceStack.Interface
{
    public interface IAppServiceHandler
    {
        bool VerificarCampos(DadosPesquisaViewModel dados);
        object AdicionarDados(DadosPesquisaViewModel dados);
        void SalvarPesquisa(BarrettValuesViewModel dados, DadosPesquisaViewModel pesquisa);
    }
}
