using SearchForm.Infra.Reprositories;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.LiderancaOrganizacional
{
    public class LiderancaOrganizacionalController : Controller
    {
        // GET: Page2
        public ActionResult LiderancaOrganizacional()
        {
            ViewBag.Alert = string.Empty;
            object dados = TempData["Teste"];
            return View();
        }

        [HttpPost]
        public ActionResult GestaoDeFuncionariosView(GlobalViewModel dados)
        {
            bool erro = checarCampos(dados);

            if (erro)
            {
                ViewBag.Alert = "Valores Incorretos. Lembre-se: A soma dos campos EXPECTATIVA e REALIDADE devem chegar em 100. Em caso de duvidas, pergunte!";
                return View("LiderancaOrganizacional");
            }
            else
            {
                TempData["Teste"] = dados;
                TempData.Keep();
            }

            Repository repo = new Repository();
            repo.SalvarLiderancaOrganizacional(dados.LiderancaOrganizacional);

            return RedirectToAction("GestaoDeFuncionarios", "GestaoDeFuncionarios");
        }

        private bool checarCampos(GlobalViewModel dados)
        {
            int letraAExpect = int.Parse(dados.LiderancaOrganizacional.LO_LetraAExpect);
            int letraAReal = int.Parse(dados.LiderancaOrganizacional.LO_LetraAReal);
            int letraBExpect = int.Parse(dados.LiderancaOrganizacional.LO_LetraBExpect);
            int letraBReal = int.Parse(dados.LiderancaOrganizacional.LO_LetraBReal);
            int letraCExpect = int.Parse(dados.LiderancaOrganizacional.LO_LetraCExpect);
            int letraCReal = int.Parse(dados.LiderancaOrganizacional.LO_LetraCReal);
            int letraDExpect = int.Parse(dados.LiderancaOrganizacional.LO_LetraDExpect);
            int letraDReal = int.Parse(dados.LiderancaOrganizacional.LO_LetraDReal);

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