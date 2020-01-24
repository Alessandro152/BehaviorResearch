
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;

namespace SearchForm.Models.QueryStack.Interface
{
    public interface IRepository
    {
        void SalvarPesquisa(BarrettValuesViewModel dados, DadosPesquisaViewModel pesquisa);
    }
}
