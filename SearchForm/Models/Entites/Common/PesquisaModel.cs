namespace SearchForm.Models.Entites.Common
{
    using SearchForm.Models.Entites.Funcionario;
    using SearchForm.Models.Entites.Pesquisa;

    public class PesquisaModel : FuncionarioModel
    {
        public CaracteristicasDominantesModel CaracteristicasDominantes { get; set; }

        public LiderancaOrganizacionalModel LiderancaOrganizacional { get; set; }

        public ColagemDeOrganizacaoModel ColagemDeOrganizacao { get; set; }

        public EnfaseEstrategicaModel EnfaseEstrategica { get; set; }

        public CriteriosDeSucessoModel CriteriosDeSucesso { get; set; }

        public GestaoDeFuncionariosModel GestaoDeFuncionarios { get; set; }

        public BarrettValuesModel BarrettValues { get; set; }
    }
}