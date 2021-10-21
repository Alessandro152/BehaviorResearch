
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;
using System.Threading.Tasks;

namespace SearchForm.Models.ServiceStack.Interface
{
    public interface IAppServiceHandler
    {
        bool VerificarCampos(DadosPesquisaViewModel dados);

        DadosPesquisaViewModel AdicionarDados(DadosPesquisaViewModel dados);

        Task<bool> SalvarPesquisa(BarrettValuesViewModel dados, DadosPesquisaViewModel pesquisa);
    }
}
