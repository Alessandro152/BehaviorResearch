
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;

namespace SearchForm.Models.ServiceStack.Interface
{
    public interface IAppServiceHandler
    {
        bool VerificarCampos(DadosPesquisaViewModel dados);
        void SalvarBarrettValues(BarrettValuesViewModel barrettValues);
        void SalvarRespostas(DadosPesquisaViewModel dados);
    }
}
