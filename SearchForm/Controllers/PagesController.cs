using System.Web.Mvc;

namespace SearchForm.Controllers
{
    public class PagesController : Controller
    {
        public PagesController()
        {
        }

        [HttpGet]
        public ActionResult Index()
            => View();

        [HttpGet]
        public ActionResult InicializarPaginaExpectReality()
            => View("ExpectReality");

        [HttpGet]
        public ActionResult InicializarPaginaBarrettValues()
            => View("BarrettValues");

        [HttpGet]
        public ActionResult FinalizarPesquisa()
            => View("Finish");
    }
}