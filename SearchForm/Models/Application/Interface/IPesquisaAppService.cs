
namespace SearchForm.Models.Application.Interface
{
    using SearchForm.Models.Entites.Common;
    using System.Threading.Tasks;

    public interface IPesquisaAppService
    {
        Task<bool> SalvarPesquisa(PesquisaModel dados);
    }
}
