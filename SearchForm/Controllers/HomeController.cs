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

        [HttpPost]
        public ActionResult CaracteristicasDominantesView(GlobalViewModel dados)
        {

            TempData["Teste"] = dados;
            TempData.Keep("Teste");

            //Repository repo = new Repository();
            //repo.SalvarDadosPessoa(dados.Pessoa);

            return RedirectToAction("CaractetisticasDominantes", "CaractetisticasDominantes");
        }
    }
}