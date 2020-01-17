using SearchForm.Application;
using SearchForm.Controllers.Interface;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.Principal
{
    public class PagesController : Controller
    {
        private const string ERRO = "Dados Incorretos. Lembre-se: Um unico campo nao pode ser maior que 100 e nem a soma dos quatro campos de expectativa ou realidade pode ser maior que 100";
        private readonly IRepository _repo;
        private readonly SearchFormAppServiceHandler _appServiceHandler;

        //Construtor do controller. Ele irá instanciar apenas uma vez o repositório
        public PagesController(IRepository repo, SearchFormAppServiceHandler appServiceHandler)
        {
            _repo = repo;
            _appServiceHandler = appServiceHandler;
        }

        #region PaginaPrincipal
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region CaracteristicasDominantes
        [HttpPost]
        public ActionResult ToPage2View(GlobalViewModel dados)
        {
            TempData["Pessoa"] = new personViewModel()
            {
                Nome = dados.Pessoa.Nome,
                Departamento = dados.Pessoa.Departamento,
                Cargo = dados.Pessoa.Cargo
            };

            return RedirectToAction("Page2");
        }

        public ActionResult Page2()
        {
            ViewBag.Alert = string.Empty;
            if(TempData["Pessoa"] != null) TempData.Keep("Pessoa");
            return View();
        }
        #endregion

        #region Respostas
        [HttpPost]
        public ActionResult AnswersView(GlobalViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);           

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("Page2");
            }
            else
            {
                dados.Pessoa = TempData["Pessoa"] as personViewModel;
                _repo.SalvarRespostas(dados);
                return RedirectToAction("BarrettValues");
            }
        }
        #endregion

        #region BarrettValues
        public ActionResult BarrettValues()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FinishView(GlobalViewModel dados)
        {
            _repo.SalvarBarrettValues(dados.BarrettValues);
            return RedirectToAction("Finish");
        }
        #endregion

        #region Finish
        public ActionResult Finish()
        {
            return View();
        }
        #endregion
    }
}