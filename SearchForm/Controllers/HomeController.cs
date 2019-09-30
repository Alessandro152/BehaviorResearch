using SearchForm.Controllers.Interface;
using SearchForm.Models.ViewModels;
using System.Web.Mvc;

namespace SearchForm.Controllers.Principal
{
    public class HomeController : Controller
    {
        private const string ERRO = "Dados Incorretos. Lembre-se: Um unico campo nao pode ser maior que 100 e nem a soma dos quatro campos de expectativa ou realidade pode ser maior que 100";
        private readonly IRepository _repo;

        //Construtor do controller. Ele irá instanciar apenas uma vez o repositório
        public HomeController(IRepository repo)
        {
            _repo = repo;
        }

        #region PaginaPrincipal
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region CaracteristicasDominantes
        [HttpPost]
        public ActionResult CaracteristicasDominantesView(GlobalViewModel dados)
        {
            _repo.SalvarDadosPessoa(dados.Pessoa);
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
        public ActionResult LiderancaOrganizacionalView(GlobalViewModel dados)
        {
            bool HasSumError = VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("CaractetisticasDominantes");
            }
            else
            {
                _repo.SalvarCaracteristicasDominantes(dados.CaracteristicasDominantes);
                return RedirectToAction("LiderancaOrganizacional");
            }
        }

        public ActionResult LiderancaOrganizacional()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region GestaoDeFuncionarios
        [HttpPost]
        public ActionResult GestaoDeFuncionariosView(GlobalViewModel dados)
        {
            bool HasSumError = VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("LiderancaOrganizacional");
            }
            else
            {
                _repo.SalvarLiderancaOrganizacional(dados.LiderancaOrganizacional);
                return RedirectToAction("GestaoDeFuncionarios");
            }
        }

        public ActionResult GestaoDeFuncionarios()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region ColagemDeOrganizacao
        [HttpPost]
        public ActionResult ColagemDeOrganizacaoView(GlobalViewModel dados)
        {
            bool HasSumError = VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("GestaoDeFuncionarios");
            }
            else
            {
                _repo.SalvarGestaoDeFuncionarios(dados.GestaoDeFuncionarios);
                return RedirectToAction("ColagemDeOrganizacao");
            }
        }

        public ActionResult ColagemDeOrganizacao()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region EnfaseEstrategica
        [HttpPost]
        public ActionResult EnfaseEstrategicaView(GlobalViewModel dados)
        {
            bool HasSumError = VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("ColagemDeOrganizacao");
            }
            else
            {
                _repo.SalvarColagemDeOrganizacao(dados.ColagemDeOrganizacao);
                return RedirectToAction("EnfaseEstrategica");
            }
        }

        public ActionResult EnfaseEstrategica()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region CriteriosDeSucesso
        [HttpPost]
        public ActionResult CriteriosDeSucessoView(GlobalViewModel dados)
        {
            bool HasSumError = VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("EnfaseEstrategica");
            }
            else
            {
                _repo.SalvarEnfaseEstrategica(dados.EnfaseEstrategica);
                return RedirectToAction("CriteriosDeSucesso");
            }
        }

        public ActionResult CriteriosDeSucesso()
        {
            ViewBag.Alert = string.Empty;
            return View();
        }
        #endregion

        #region BarrettValues
        [HttpPost]
        public ActionResult BarrettValuesView(GlobalViewModel dados)
        {
            bool HasSumError = VerificarCampos(dados);

            if (HasSumError)
            {
                ViewBag.Alert = ERRO;
                return View("CriteriosDeSucesso");
            }
            else
            {
                _repo.SalvarCriteriosDeSucesso(dados.CriteriosDeSucesso);
                return RedirectToAction("Finish");
            }
        }

        public ActionResult Finish()
        {
            return View();
        }
        #endregion



        //Metodo que converte os campos em inteiro para fazer o calculo.
        private bool VerificarCampos(GlobalViewModel dados)
        {
            int LetraAExpect;
            int LetraAReal;
            int LetraBExpect;
            int LetraBReal;
            int LetraCExpect;
            int LetraCReal;
            int LetraDExpect;
            int LetraDReal;

            if (dados.CaracteristicasDominantes != null)
            {
                int.TryParse(dados.CaracteristicasDominantes.CD_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.CaracteristicasDominantes.CD_LetraAReal, out LetraAReal);
                int.TryParse(dados.CaracteristicasDominantes.CD_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.CaracteristicasDominantes.CD_LetraBReal, out LetraBReal);
                int.TryParse(dados.CaracteristicasDominantes.CD_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.CaracteristicasDominantes.CD_LetraCReal, out LetraCReal);
                int.TryParse(dados.CaracteristicasDominantes.CD_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.CaracteristicasDominantes.CD_LetraDReal, out LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.LiderancaOrganizacional != null)
            {
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraAReal, out LetraAReal);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraBReal, out LetraBReal);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraCReal, out LetraCReal);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraDReal, out LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.GestaoDeFuncionarios != null)
            {
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraAReal, out LetraAReal);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraBReal, out LetraBReal);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraCReal, out LetraCReal);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraDReal, out LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.ColagemDeOrganizacao != null)
            {
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraAReal, out LetraAReal);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraBReal, out LetraBReal);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraCReal, out LetraCReal);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraDReal, out LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.EnfaseEstrategica != null)
            {
                int.TryParse(dados.EnfaseEstrategica.EE_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraAReal, out LetraAReal);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraBReal, out LetraBReal);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraCReal, out LetraCReal);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraDReal, out LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.CriteriosDeSucesso != null)
            {
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraAReal, out LetraAReal);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraBReal, out LetraBReal);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraCReal, out LetraCReal);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraDReal, out LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            return false;
        }

        //Soma os campos EXPECTATIVA e REALIDADE. Se ultrapassar em 100, retorna alerta ao usuário de que está errado.
        private bool SomarValores(int LetraAExpect, int LetraAReal, int LetraBExpect, int LetraBReal, int LetraCExpect, int LetraCReal, int LetraDExpect, int LetraDReal)
        {
            if (LetraAExpect > 100 || LetraAReal > 100 || LetraBExpect > 100 || LetraBReal > 100 || LetraCExpect > 100 || LetraCReal > 100 || LetraDExpect > 100 || LetraDReal > 100)
            {
                return true;
            }
            else if ((LetraAExpect + LetraBExpect + LetraCExpect + LetraDExpect > 100 || LetraAExpect + LetraBExpect + LetraCExpect + LetraDExpect < 100) || (LetraAReal + LetraBReal + LetraCReal + LetraDReal > 100 || LetraAReal + LetraBReal + LetraCReal + LetraDReal < 100))
            {
                return true;
            }

            return false;
        }
    }
}