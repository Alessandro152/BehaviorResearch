
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;
using System.Threading.Tasks;

namespace SearchForm.Models.ServiceStack.Interface
{
    public interface IAppServiceHandler
    {
        bool VerificarCampos(DadosPesquisaModel dados);

        DadosPesquisaModel AdicionarDados(DadosPesquisaModel dados);

        Task<bool> SalvarPesquisa(BarrettValuesViewModel dados, DadosPesquisaModel pesquisa);
    }
}
