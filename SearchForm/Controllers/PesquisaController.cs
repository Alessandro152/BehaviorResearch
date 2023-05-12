using System.Web.Mvc;

namespace SearchForm.Controllers
{
    [Route("pesquisas")]
    [Authorize]
    public class PesquisaController : Controller
    {
        public PesquisaController()
        {

        }

        [HttpPost]
        [Route("funcionario")]
        public ActionResult SalvarFuncionario()
            => View("ExpectReality");
    }
}