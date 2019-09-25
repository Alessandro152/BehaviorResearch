
using SearchForm.Infra.Reprositories;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.CaractetisticasDominantes
{
    public class CaractetisticasDominantesController : Controller
    {
        // GET: Page1
        public ActionResult CaractetisticasDominantes()
        {
            ViewBag.Alert = string.Empty;
            object dados = TempData["Teste"];
            return View();
        }

        [HttpPost]
        public ActionResult LiderancaOrganizacionalView(GlobalViewModel dados)
        {
            bool erro = ChecarCampos(dados);

            if (erro)
            {
                ViewBag.Alert = "Valores Incorretos. Lembre-se: A soma dos campos EXPECTATIVA e REALIDADE devem chegar em 100. Em caso de duvidas, pergunte!";
                return View("CaractetisticasDominantes");
            }
            else
            {
                TempData["Teste"] = dados;
                TempData.Keep("Teste");
                return RedirectToAction("LiderancaOrganizacional", "LiderancaOrganizacional");
            }
            //Repository repo = new Repository();
            //repo.SalvarCaracteristicasDominantes(dados.CaracteristicasDominantes);
        }

        private bool ChecarCampos(GlobalViewModel dados)
        {
            int letraAExpect = int.Parse(dados.CaracteristicasDominantes.CD_LetraAExpect);
            int letraAReal = int.Parse(dados.CaracteristicasDominantes.CD_LetraAReal);
            int letraBExpect = int.Parse(dados.CaracteristicasDominantes.CD_LetraBExpect);
            int letraBReal = int.Parse(dados.CaracteristicasDominantes.CD_LetraBReal);
            int letraCExpect = int.Parse(dados.CaracteristicasDominantes.CD_LetraCExpect);
            int letraCReal = int.Parse(dados.CaracteristicasDominantes.CD_LetraCReal);
            int letraDExpect = int.Parse(dados.CaracteristicasDominantes.CD_LetraDExpect);
            int letraDReal = int.Parse(dados.CaracteristicasDominantes.CD_LetraDReal);

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