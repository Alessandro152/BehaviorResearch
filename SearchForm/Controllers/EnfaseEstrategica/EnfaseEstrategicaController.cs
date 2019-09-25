using SearchForm.Infra.Reprositories;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.EnfaseEstrategica
{
    public class EnfaseEstrategicaController : Controller
    {
        // GET: EnfaseEstrategica
        public ActionResult EnfaseEstrategica()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }

        [HttpPost]
        public ActionResult CriteriosDeSucessoView(GlobalViewModel enfase)
        {
            bool erro = checarCampos(enfase);

            if (erro)
            {
                ViewBag.Alert = "Valores Incorretos. Lembre-se: A soma dos campos EXPECTATIVA e REALIDADE devem chegar em 100. Em caso de duvidas, pergunte!";
                return View("LiderancaOrganizacional");
            }
            Repository repo = new Repository();
            repo.SalvarEnfaseEstrategica(enfase.EnfaseEstrategica);

            return RedirectToAction("CriteriosDeSucesso", "CriteriosDeSucesso");
        }

        private bool checarCampos(GlobalViewModel dados)
        {
            int letraAExpect = int.Parse(dados.EnfaseEstrategica.EE_LetraAExpect);
            int letraAReal = int.Parse(dados.EnfaseEstrategica.EE_LetraAReal);
            int letraBExpect = int.Parse(dados.EnfaseEstrategica.EE_LetraBExpect);
            int letraBReal = int.Parse(dados.EnfaseEstrategica.EE_LetraBReal);
            int letraCExpect = int.Parse(dados.EnfaseEstrategica.EE_LetraCExpect);
            int letraCReal = int.Parse(dados.EnfaseEstrategica.EE_LetraCReal);
            int letraDExpect = int.Parse(dados.EnfaseEstrategica.EE_LetraDExpect);
            int letraDReal = int.Parse(dados.EnfaseEstrategica.EE_LetraDReal);

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