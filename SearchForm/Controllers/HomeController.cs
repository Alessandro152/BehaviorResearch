using SearchForm.Infra.Reprositories;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.Principal
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        #region CaracteristicasDominantes
        [HttpPost]
        public ActionResult CaracteristicasDominantesView()
        {
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
        public ActionResult LiderancaOrganizacionalView()
        {
            return RedirectToAction("LiderancaOrganizacional");
        }

        public ActionResult LiderancaOrganizacional()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region GestaoDeFuncionarios
        [HttpPost]
        public ActionResult GestaoDeFuncionariosView()
        {
            return RedirectToAction("GestaoDeFuncionarios");
        }

        public ActionResult GestaoDeFuncionarios()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region ColagemDeOrganizacao
        [HttpPost]
        public ActionResult ColagemDeOrganizacaoView()
        {
            return RedirectToAction("ColagemDeOrganizacao");
        }

        public ActionResult ColagemDeOrganizacao()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region EnfaseEstrategica
        [HttpPost]
        public ActionResult EnfaseEstrategicaView()
        {
            return RedirectToAction("EnfaseEstrategica");
        }

        public ActionResult EnfaseEstrategica()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region CriteriosDeSucesso
        [HttpPost]
        public ActionResult CriteriosDeSucessoView()
        {
            return RedirectToAction("CriteriosDeSucesso");
        }

        public ActionResult CriteriosDeSucesso()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        [HttpPost]
        public ActionResult BarrettValuesView(GlobalViewModel dados)
        {
            Repository repo = new Repository();
            repo.SalvarDadosPessoa(dados.Pessoa);

            return View("Index");
        }
    }
}