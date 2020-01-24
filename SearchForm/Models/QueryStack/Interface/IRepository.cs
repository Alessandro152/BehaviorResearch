
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;

namespace SearchForm.Models.QueryStack.Interface
{
    public interface IRepository
    {
        void SalvarRespostas(DadosPesquisaViewModel dados);
        void SalvarBarrettValues(BarrettValuesViewModel barrettValues);
    }
}
