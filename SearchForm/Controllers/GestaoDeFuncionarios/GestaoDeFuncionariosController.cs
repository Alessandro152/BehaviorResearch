using SearchForm.Infra.Reprositories;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.GestaoDeFuncionarios
{
    public class GestaoDeFuncionariosController : Controller
    {
        // GET: GestaoDeFuncionarios
        public ActionResult GestaoDeFuncionarios()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }

        [HttpPost]
        public ActionResult ColagemDeOrganizacaoView(GlobalViewModel gestao)
        {
            bool erro = checarCampos(gestao);

            if (erro)
            {
                ViewBag.Alert = "Valores Incorretos. Lembre-se: A soma dos campos EXPECTATIVA e REALIDADE devem chegar em 100. Em caso de duvidas, pergunte!";
                return View("LiderancaOrganizacional");
            }
            Repository repo = new Repository();
            repo.SalvarGestaoDeFuncionarios(gestao.GestaoDeFuncionarios);

            return RedirectToAction("ColagemDeOrganizacao", "ColagemDeOrganizacao");
        }

        private bool checarCampos(GlobalViewModel dados)
        {
            int letraAExpect = int.Parse(dados.GestaoDeFuncionarios.GF_LetraAExpect);
            int letraAReal = int.Parse(dados.GestaoDeFuncionarios.GF_LetraAReal);
            int letraBExpect = int.Parse(dados.GestaoDeFuncionarios.GF_LetraBExpect);
            int letraBReal = int.Parse(dados.GestaoDeFuncionarios.GF_LetraBReal);
            int letraCExpect = int.Parse(dados.GestaoDeFuncionarios.GF_LetraCExpect);
            int letraCReal = int.Parse(dados.GestaoDeFuncionarios.GF_LetraCReal);
            int letraDExpect = int.Parse(dados.GestaoDeFuncionarios.GF_LetraDExpect);
            int letraDReal = int.Parse(dados.GestaoDeFuncionarios.GFLetraDReal);

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