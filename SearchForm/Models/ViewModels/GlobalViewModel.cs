using SearchForm.Models.ViewModels.BarrettValues;
using SearchForm.Models.ViewModels.CaracteristicasDominantes;
using SearchForm.Models.ViewModels.ColagemDeOrganizacao;
using SearchForm.Models.ViewModels.CriteriosDeSucesso;
using SearchForm.Models.ViewModels.EnfaseEstrategica;
using SearchForm.Models.ViewModels.GestaoDeFuncionarios;
using SearchForm.Models.ViewModels.LiderancaOrganizacional;

namespace SearchForm.Models.ViewModels
{
    public class GlobalViewModel
    {
        public personViewModel Pessoa { get; set; }
        public CaracteristicasDominantesViewModel CaracteristicasDominantes { get; set; }
        public LiderancaOrganizacionalViewModel LiderancaOrganizacional { get; set; }
        public ColagemDeOrganizacaoViewModel ColagemDeOrganizacao { get; set; }
        public EnfaseEstrategicaViewModel EnfaseEstrategica { get; set; }
        public CriteriosDeSucessoViewModel CriteriosDeSucesso { get; set; }
        public GestaoDeFuncionariosViewModel GestaoDeFuncionarios { get; set; }
        public BarrettValuesViewModel BarrettValues { get; set; }
    }
}