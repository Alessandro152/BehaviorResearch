
using SearchForm.Models.QueryStack.ViewModels.Funcionario;
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;
using SearchForm.Models.ServiceStack.Interface;
using System;
using System.Web.Mvc;

namespace SearchForm.Controllers.Principal
{
    public class PagesController : Controller
    {
        private const string ERRO = "Dados Incorretos. Lembre-se: Um unico campo nao pode ser maior que 100 e nem a soma dos quatro campos de expectativa ou realidade pode ser maior que 100";
        private readonly IAppServiceHandler _appServiceHandler;

        //Construtor do controller. Ele irá instanciar apenas uma vez o repositório
        public PagesController(IAppServiceHandler appServiceHandler)
        {
            _appServiceHandler = appServiceHandler;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalvarDadosFuncionario(FuncionarioViewModel dados)
        {
            TempData["Funcionario"] = new FuncionarioViewModel()
            {
                Nome = dados.Nome,
                Departamento = dados.Departamento,
                Cargo = dados.Cargo
            };

            return RedirectToAction("Pesquisa");
        }

        public ActionResult Pesquisa()
        {
            if(TempData["Funcionario"] != null) TempData.Keep("Funcionario");
            return View("Page2");
        }

        [HttpPost]
        public ActionResult SalvarPesquisa(DadosPesquisaViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);           

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("Page2");
            }
            else
            {
                dados.Funcionario = TempData["Funcionario"] as FuncionarioViewModel;
                TempData["DadosPesquisa"] = _appServiceHandler.AdicionarDados(dados);
                return View("BarrettValues");
            }
        }

        [HttpPost]
        public ActionResult Finalizar(BarrettValuesViewModel dados)
        {
            var pesquisa = TempData["DadosPesquisa"] as DadosPesquisaViewModel;
            _appServiceHandler.SalvarPesquisa(dados, pesquisa);
            return View("Finish");
        }

    }
}