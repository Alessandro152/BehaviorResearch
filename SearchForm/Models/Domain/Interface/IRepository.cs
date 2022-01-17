
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;
using System.Threading.Tasks;

namespace SearchForm.Models.QueryStack.Interface
{
    public interface IRepository
    {
        Task<bool> SalvarPesquisa(BarrettValuesViewModel dados, DadosPesquisaModel pesquisa);
    }
}
