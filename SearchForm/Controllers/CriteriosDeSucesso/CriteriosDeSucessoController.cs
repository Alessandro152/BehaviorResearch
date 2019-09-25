
using SearchForm.Infra.Reprositories;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.CriteriosDeSucesso
{
    public class CriteriosDeSucessoController : Controller
    {
        // GET: CriteriosDeSucesso
        public ActionResult CriteriosDeSucesso()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }

        [HttpPost]
        public ActionResult BarrettValuesView(GlobalViewModel criterios)
        {
            bool erro = checarCampos(criterios);

            if (erro)
            {
                ViewBag.Alert = "Valores Incorretos. Lembre-se: A soma dos campos EXPECTATIVA e REALIDADE devem chegar em 100. Em caso de duvidas, pergunte!";
                return View("LiderancaOrganizacional");
            }
            Repository repo = new Repository();
            repo.SalvarCriteriosDeSucesso(criterios.CriteriosDeSucesso);

            return RedirectToAction("BarrettValues", "BarrettValues");
        }

        private bool checarCampos(GlobalViewModel dados)
        {
            int letraAExpect = int.Parse(dados.CriteriosDeSucesso.CS_LetraAExpect);
            int letraAReal = int.Parse(dados.CriteriosDeSucesso.CS_LetraAReal);
            int letraBExpect = int.Parse(dados.CriteriosDeSucesso.CS_LetraBExpect);
            int letraBReal = int.Parse(dados.CriteriosDeSucesso.CS_LetraBReal);
            int letraCExpect = int.Parse(dados.CriteriosDeSucesso.CS_LetraCExpect);
            int letraCReal = int.Parse(dados.CriteriosDeSucesso.CS_LetraCReal);
            int letraDExpect = int.Parse(dados.CriteriosDeSucesso.CS_LetraDExpect);
            int letraDReal = int.Parse(dados.CriteriosDeSucesso.CS_LetraDReal);

            if (letraAExpect >= 100 || letraAReal >= 100 || letraBExpect >= 100 || letraBReal >= 100 || letraCExpect >= 100 || letraCReal >= 100 || letraDExpect >= 100 || letraDReal >= 100)
            {
                return true;
            }
            else if ((letraAExpect + letraBExpect + letraCExpect + letraDExpect > 100) || (letraAReal + letraBReal + letraCReal + letraDReal > 100))
            {
                return true;
            }

            return false;
        }
    }
}