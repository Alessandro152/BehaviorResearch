using SearchForm.Models.QueryStack.ViewModels.Funcionario;


namespace SearchForm.Models.QueryStack.ViewModels.Pesquisa
{
    public class DadosPesquisaViewModel
    {
        public FuncionarioViewModel Funcionario { get; set; }
        public CaracteristicasDominantesViewModel CaracteristicasDominantes { get; set; }
        public LiderancaOrganizacionalViewModel LiderancaOrganizacional { get; set; }
        public ColagemDeOrganizacaoViewModel ColagemDeOrganizacao { get; set; }
        public EnfaseEstrategicaViewModel EnfaseEstrategica { get; set; }
        public CriteriosDeSucessoViewModel CriteriosDeSucesso { get; set; }
        public GestaoDeFuncionariosViewModel GestaoDeFuncionarios { get; set; }
        public BarrettValuesViewModel BarrettValues { get; set; }
    }
}