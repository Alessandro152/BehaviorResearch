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
        public ActionResult CaracteristicasDominantesView(GlobalViewModel dados)
        {
            _repo.SalvarDadosPessoa(dados.Pessoa);
            return RedirectToAction("CaractetisticasDominantes");
        }

        public ActionResult CaractetisticasDominantes()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region LiderancaOrganizacional
        [HttpPost]
        public ActionResult LiderancaOrganizacionalView(GlobalViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("CaractetisticasDominantes");
            }
            else
            {
                _repo.SalvarCaracteristicasDominantes(dados.CaracteristicasDominantes);
                return RedirectToAction("LiderancaOrganizacional");
            }
        }

        public ActionResult LiderancaOrganizacional()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region GestaoDeFuncionarios
        [HttpPost]
        public ActionResult GestaoDeFuncionariosView(GlobalViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("LiderancaOrganizacional");
            }
            else
            {
                _repo.SalvarLiderancaOrganizacional(dados.LiderancaOrganizacional);
                return RedirectToAction("GestaoDeFuncionarios");
            }
        }

        public ActionResult GestaoDeFuncionarios()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region ColagemDeOrganizacao
        [HttpPost]
        public ActionResult ColagemDeOrganizacaoView(GlobalViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("GestaoDeFuncionarios");
            }
            else
            {
                _repo.SalvarGestaoDeFuncionarios(dados.GestaoDeFuncionarios);
                return RedirectToAction("ColagemDeOrganizacao");
            }
        }

        public ActionResult ColagemDeOrganizacao()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region EnfaseEstrategica
        [HttpPost]
        public ActionResult EnfaseEstrategicaView(GlobalViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("ColagemDeOrganizacao");
            }
            else
            {
                _repo.SalvarColagemDeOrganizacao(dados.ColagemDeOrganizacao);
                return RedirectToAction("EnfaseEstrategica");
            }
        }

        public ActionResult EnfaseEstrategica()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region CriteriosDeSucesso
        [HttpPost]
        public ActionResult CriteriosDeSucessoView(GlobalViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("EnfaseEstrategica");
            }
            else
            {
                _repo.SalvarEnfaseEstrategica(dados.EnfaseEstrategica);
                return RedirectToAction("CriteriosDeSucesso");
            }
        }

        public ActionResult CriteriosDeSucesso()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region BarrettValues
        [HttpPost]
        public ActionResult BarrettValuesView(GlobalViewModel dados)
        {
            bool HasSumError = _appServiceHandler.VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("CriteriosDeSucesso");
            }
            else
            {
                _repo.SalvarCriteriosDeSucesso(dados.CriteriosDeSucesso);
                return RedirectToAction("BarrettValues");
            }
        }
        #endregion

        #region Finish
        public ActionResult BarrettValues()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FinishView(GlobalViewModel dados)
        {
            _repo.SalvarBarrettValues(dados.BarrettValues);
            return View("Finish");
        }
        #endregion
        
    }
}