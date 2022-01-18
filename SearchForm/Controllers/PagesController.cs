namespace SearchForm.Controllers.Principal
{
    using SearchForm.Models.Entites.Funcionario;
    using SearchForm.Models.Entites.Common;
    using System.Web.Mvc;
    using SearchForm.Models.Entites.Pesquisa;
    using SearchForm.Models.Application.Interface;

    public class PagesController : Controller
    {
        private readonly IPesquisaAppService _pesquisaAppService;

        public PagesController(IPesquisaAppService appServiceHandler)
        {
            _pesquisaAppService = appServiceHandler;
        }

        public FuncionarioModel Funcionario { get; set; }

        public PesquisaModel DadosPesquisa { get; set; }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InicializarPaginaExpectReality(FuncionarioModel dados)
        {
            if (dados == null) return View();

            Funcionario = dados;

            return View("ExpectReality");
        }

        [HttpPost]
        public ActionResult InicializarPaginaBarrettValues(PesquisaModel pesquisaValues)
        {
            if (pesquisaValues == null) return View();

            DadosPesquisa.Nome = Funcionario.Nome;
            DadosPesquisa.Cargo = Funcionario.Cargo;
            DadosPesquisa.Departamento = Funcionario.Departamento;
            DadosPesquisa = pesquisaValues;

            return View("BarrettValues");
        }

        [HttpPost]
        public ActionResult FinalizarPesquisa(BarrettValuesModel barrettValues)
        {
            if (barrettValues == null) return View();

            DadosPesquisa.BarrettValues = barrettValues;

            var result = _pesquisaAppService.SalvarPesquisa(DadosPesquisa).Result;

            if (!result)
            {
                // TODO - Criar tela que não gravou as informacoes
            }

            return View("Finish");
        }
    }
}