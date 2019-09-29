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
            if (dados.CaracteristicasDominantes != null)
            {
                int LetraAExpect = int.Parse(dados.CaracteristicasDominantes.CD_LetraAExpect);
                int LetraAReal = int.Parse(dados.CaracteristicasDominantes.CD_LetraAReal);
                int LetraBExpect = int.Parse(dados.CaracteristicasDominantes.CD_LetraBExpect);
                int LetraBReal = int.Parse(dados.CaracteristicasDominantes.CD_LetraBReal);
                int LetraCExpect = int.Parse(dados.CaracteristicasDominantes.CD_LetraCExpect);
                int LetraCReal = int.Parse(dados.CaracteristicasDominantes.CD_LetraCReal);
                int LetraDExpect = int.Parse(dados.CaracteristicasDominantes.CD_LetraDExpect);
                int LetraDReal = int.Parse(dados.CaracteristicasDominantes.CD_LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.LiderancaOrganizacional != null)
            {
                int LetraAExpect = int.Parse(dados.LiderancaOrganizacional.LO_LetraAExpect);
                int LetraAReal = int.Parse(dados.LiderancaOrganizacional.LO_LetraAReal);
                int LetraBExpect = int.Parse(dados.LiderancaOrganizacional.LO_LetraBExpect);
                int LetraBReal = int.Parse(dados.LiderancaOrganizacional.LO_LetraBReal);
                int LetraCExpect = int.Parse(dados.LiderancaOrganizacional.LO_LetraCExpect);
                int LetraCReal = int.Parse(dados.LiderancaOrganizacional.LO_LetraCReal);
                int LetraDExpect = int.Parse(dados.LiderancaOrganizacional.LO_LetraDExpect);
                int LetraDReal = int.Parse(dados.LiderancaOrganizacional.LO_LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.GestaoDeFuncionarios != null)
            {
                int LetraAExpect = int.Parse(dados.GestaoDeFuncionarios.GF_LetraAExpect);
                int LetraAReal = int.Parse(dados.GestaoDeFuncionarios.GF_LetraAReal);
                int LetraBExpect = int.Parse(dados.GestaoDeFuncionarios.GF_LetraBExpect);
                int LetraBReal = int.Parse(dados.GestaoDeFuncionarios.GF_LetraBReal);
                int LetraCExpect = int.Parse(dados.GestaoDeFuncionarios.GF_LetraCExpect);
                int LetraCReal = int.Parse(dados.GestaoDeFuncionarios.GF_LetraCReal);
                int LetraDExpect = int.Parse(dados.GestaoDeFuncionarios.GF_LetraDExpect);
                int LetraDReal = int.Parse(dados.GestaoDeFuncionarios.GF_LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.ColagemDeOrganizacao != null)
            {
                int LetraAExpect = int.Parse(dados.ColagemDeOrganizacao.CO_LetraAExpect);
                int LetraAReal = int.Parse(dados.ColagemDeOrganizacao.CO_LetraAReal);
                int LetraBExpect = int.Parse(dados.ColagemDeOrganizacao.CO_LetraBExpect);
                int LetraBReal = int.Parse(dados.ColagemDeOrganizacao.CO_LetraBReal);
                int LetraCExpect = int.Parse(dados.ColagemDeOrganizacao.CO_LetraCExpect);
                int LetraCReal = int.Parse(dados.ColagemDeOrganizacao.CO_LetraCReal);
                int LetraDExpect = int.Parse(dados.ColagemDeOrganizacao.CO_LetraDExpect);
                int LetraDReal = int.Parse(dados.ColagemDeOrganizacao.CO_LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.EnfaseEstrategica != null)
            {
                int LetraAExpect = int.Parse(dados.EnfaseEstrategica.EE_LetraAExpect);
                int LetraAReal = int.Parse(dados.EnfaseEstrategica.EE_LetraAReal);
                int LetraBExpect = int.Parse(dados.EnfaseEstrategica.EE_LetraBExpect);
                int LetraBReal = int.Parse(dados.EnfaseEstrategica.EE_LetraBReal);
                int LetraCExpect = int.Parse(dados.EnfaseEstrategica.EE_LetraCExpect);
                int LetraCReal = int.Parse(dados.EnfaseEstrategica.EE_LetraCReal);
                int LetraDExpect = int.Parse(dados.EnfaseEstrategica.EE_LetraDExpect);
                int LetraDReal = int.Parse(dados.EnfaseEstrategica.EE_LetraDReal);

                return SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);
            }
            else if (dados.CriteriosDeSucesso != null)
            {
                int LetraAExpect = int.Parse(dados.CriteriosDeSucesso.CS_LetraAExpect);
                int LetraAReal = int.Parse(dados.CriteriosDeSucesso.CS_LetraAReal);
                int LetraBExpect = int.Parse(dados.CriteriosDeSucesso.CS_LetraBExpect);
                int LetraBReal = int.Parse(dados.CriteriosDeSucesso.CS_LetraBReal);
                int LetraCExpect = int.Parse(dados.CriteriosDeSucesso.CS_LetraCExpect);
                int LetraCReal = int.Parse(dados.CriteriosDeSucesso.CS_LetraCReal);
                int LetraDExpect = int.Parse(dados.CriteriosDeSucesso.CS_LetraDExpect);
                int LetraDReal = int.Parse(dados.CriteriosDeSucesso.CS_LetraDReal);

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