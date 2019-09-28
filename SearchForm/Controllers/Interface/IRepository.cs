using SearchForm.Models.ViewModels;
using SearchForm.Models.ViewModels.CaracteristicasDominantes;
using SearchForm.Models.ViewModels.ColagemDeOrganizacao;
using SearchForm.Models.ViewModels.CriteriosDeSucesso;
using SearchForm.Models.ViewModels.EnfaseEstrategica;
using SearchForm.Models.ViewModels.GestaoDeFuncionarios;
using SearchForm.Models.ViewModels.LiderancaOrganizacional;

namespace SearchForm.Controllers.Interface
{
    public interface IRepository
    {
        void SalvarDadosPessoa(personViewModel pessoa);
        void SalvarCaracteristicasDominantes(CaracteristicasDominantesViewModel caracteristicasDominantes);
        void SalvarLiderancaOrganizacional(LiderancaOrganizacionalViewModel liderancaOrganizacional);
        void SalvarGestaoDeFuncionarios(GestaoDeFuncionariosViewModel gestaoDeFuncionarios);
        void SalvarEnfaseEstrategica(EnfaseEstrategicaViewModel enfaseEstrategica);
        void SalvarCriteriosDeSucesso(CriteriosDeSucessoViewModel criteriosDeSucesso);
        void SalvarColagemDeOrganizacao(ColagemDeOrganizacaoViewModel colagemDeOrganizacao);
    }
}
