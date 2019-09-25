using SearchForm.Infra.Reprositories;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.ColagemDeOrganizacao
{
    public class ColagemDeOrganizacaoController : Controller
    {
        // GET: ColagemDeOrganizacao
        public ActionResult ColagemDeOrganizacao()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }

        [HttpPost]
        public ActionResult EnfaseEstrategicaView(GlobalViewModel colagem)
        {
            bool erro = checarCampos(colagem);

            if (erro)
            {
                ViewBag.Alert = "Valores Incorretos. Lembre-se: A soma dos campos EXPECTATIVA e REALIDADE devem chegar em 100. Em caso de duvidas, pergunte!";
                return View("LiderancaOrganizacional");
            }
            Repository repo = new Repository();
            repo.SalvarColagemDeOrganizacao(colagem.ColagemDeOrganizacao);

            return RedirectToAction("EnfaseEstrategica", "EnfaseEstrategica");
        }

        private bool checarCampos(GlobalViewModel dados)
        {
            int letraAExpect = int.Parse(dados.ColagemDeOrganizacao.CO_LetraAExpect);
            int letraAReal = int.Parse(dados.ColagemDeOrganizacao.CO_LetraAReal);
            int letraBExpect = int.Parse(dados.ColagemDeOrganizacao.CO_LetraBExpect);
            int letraBReal = int.Parse(dados.ColagemDeOrganizacao.CO_LetraBReal);
            int letraCExpect = int.Parse(dados.ColagemDeOrganizacao.CO_LetraCExpect);
            int letraCReal = int.Parse(dados.ColagemDeOrganizacao.CO_LetraCReal);
            int letraDExpect = int.Parse(dados.ColagemDeOrganizacao.CO_LetraDExpect);
            int letraDReal = int.Parse(dados.ColagemDeOrganizacao.CO_LetraDReal);

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