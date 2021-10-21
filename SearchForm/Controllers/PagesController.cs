
using Microsoft.AspNetCore.Mvc;
using SearchForm.Models.QueryStack.ViewModels.Funcionario;
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;
using SearchForm.Models.ServiceStack.Interface;
using SearchForm.Resources;
using System.Web.Mvc;

namespace SearchForm.Controllers.Principal
{
    public class PagesController : Controller
    {
        private readonly IAppServiceHandler _appServiceHandler;

        //Construtor do controller. Ele irá instanciar apenas uma vez o repositório
        public PagesController(IAppServiceHandler appServiceHandler)
        {
            _appServiceHandler = appServiceHandler;
        }

        public FuncionarioViewModel Colaborador { get; set; }

        public DadosPesquisaViewModel Dados { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            return (IActionResult)View();
        }

        [HttpPost]
        public IActionResult SalvarDadosFuncionario(FuncionarioViewModel dados)
        {
            Colaborador = new FuncionarioViewModel()
            {
                Nome = dados.Nome,
                Departamento = dados.Departamento,
                Cargo = dados.Cargo
            };

            return (IActionResult)View("ExpectReality");
        }

        [HttpPost]
        public IActionResult SalvarPesquisa(DadosPesquisaViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);           

            if (HasSumError)
            {
                ViewBag.Alert = MessageResources.MensagemDadosIncorretos;
                return (IActionResult)View("ExpectReality");
            }
            else
            {
                dados.Funcionario = Colaborador;
                Dados = _appServiceHandler.AdicionarDados(dados);
                return (IActionResult)View("BarrettValues");
            }
        }

        [HttpPost]
        public IActionResult Finalizar(BarrettValuesViewModel dados)
        {
            var result = _appServiceHandler.SalvarPesquisa(dados, Dados).Result;

            if (!result)
            {
                // TODO - Criar tela que não gravou as informacoes
            }

            return (IActionResult)View("Finish");
        }
    }
}