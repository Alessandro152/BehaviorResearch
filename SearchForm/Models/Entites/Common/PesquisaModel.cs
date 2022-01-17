namespace SearchForm.Models.Entites.Common
{
    using SearchForm.Models.Entites.Funcionario;
    using SearchForm.Models.Entites.Pesquisa;

    public class PesquisaModel
    {
        public FuncionarioModel FuncionarioModel { get; set; }

        public CaracteristicasDominantesModel CaracteristicasDominantesModel { get; set; }

        public LiderancaOrganizacionalModel LiderancaOrganizacional { get; set; }

        public ColagemDeOrganizacaoModel ColagemDeOrganizacao { get; set; }

        public EnfaseEstrategicaModel EnfaseEstrategica { get; set; }

        public CriteriosDeSucessoModel CriteriosDeSucesso { get; set; }

        public GestaoDeFuncionariosModel GestaoDeFuncionarios { get; set; }

        public BarrettValuesModel BarrettValues { get; set; }
    }
}