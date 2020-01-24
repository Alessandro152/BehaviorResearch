
using SearchForm.Models.QueryStack.Interface;
using SearchForm.Models.QueryStack.ViewModels.Funcionario;
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;
using SearchForm.Models.ServiceStack.Interface;

namespace SearchForm.Models.ServiceStack.AppServices
{
    public class AppServiceHandler : IAppServiceHandler
    {
        private const int VALOR_CAMPO_EXPECTATIVA_REALIDADE = 200;
        private int resultado;
        private readonly IRepository _repo;

        public AppServiceHandler(IRepository repo)
        {
            _repo = repo;
        }

        public void SalvarPesquisa(BarrettValuesViewModel dados, DadosPesquisaViewModel pesquisa)
        {
            _repo.SalvarPesquisa(dados, pesquisa);
        }

        public bool VerificarCampos(DadosPesquisaViewModel dados)
        {
            int LetraAExpect, LetraAReal;
            int LetraBExpect, LetraBReal;
            int LetraCExpect, LetraCReal;
            int LetraDExpect, LetraDReal;

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

                resultado =  SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if(resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
            }
            if (dados.LiderancaOrganizacional != null)
            {
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraAReal, out LetraAReal);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraBReal, out LetraBReal);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraCReal, out LetraCReal);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.LiderancaOrganizacional.LO_LetraDReal, out LetraDReal);

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
            }
            if (dados.GestaoDeFuncionarios != null)
            {
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraAReal, out LetraAReal);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraBReal, out LetraBReal);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraCReal, out LetraCReal);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.GestaoDeFuncionarios.GF_LetraDReal, out LetraDReal);

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
            }
            if (dados.ColagemDeOrganizacao != null)
            {
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraAReal, out LetraAReal);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraBReal, out LetraBReal);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraCReal, out LetraCReal);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.ColagemDeOrganizacao.CO_LetraDReal, out LetraDReal);

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
            }
            if (dados.EnfaseEstrategica != null)
            {
                int.TryParse(dados.EnfaseEstrategica.EE_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraAReal, out LetraAReal);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraBReal, out LetraBReal);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraCReal, out LetraCReal);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.EnfaseEstrategica.EE_LetraDReal, out LetraDReal);

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
            }
            if (dados.CriteriosDeSucesso != null)
            {
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraAExpect, out LetraAExpect);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraAReal, out LetraAReal);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraBExpect, out LetraBExpect);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraBReal, out LetraBReal);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraCExpect, out LetraCExpect);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraCReal, out LetraCReal);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraDExpect, out LetraDExpect);
                int.TryParse(dados.CriteriosDeSucesso.CS_LetraDReal, out LetraDReal);

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
            }

            return false;
        }

        private int SomarValores(int LetraAExpect, int LetraAReal, int LetraBExpect, int LetraBReal, int LetraCExpect, int LetraCReal, int LetraDExpect, int LetraDReal)
        {
            return LetraAExpect + LetraAReal + LetraBExpect + LetraBReal + LetraCExpect + LetraCReal + LetraDExpect + LetraDReal;
        }
        public object AdicionarDados(DadosPesquisaViewModel dados)
        {
            DadosPesquisaViewModel dadosPesquisa = new DadosPesquisaViewModel()
            {
                Funcionario = new FuncionarioViewModel
                {
                    Nome = dados.Funcionario.Nome,
                    Departamento = dados.Funcionario.Departamento,
                    Cargo = dados.Funcionario.Cargo
                },

                CaracteristicasDominantes = new CaracteristicasDominantesViewModel
                {
                    CD_LetraAExpect = dados.CaracteristicasDominantes.CD_LetraAExpect,
                    CD_LetraAReal = dados.CaracteristicasDominantes.CD_LetraAReal,
                    CD_LetraBExpect = dados.CaracteristicasDominantes.CD_LetraBExpect,
                    CD_LetraBReal = dados.CaracteristicasDominantes.CD_LetraBReal,
                    CD_LetraCExpect = dados.CaracteristicasDominantes.CD_LetraCExpect,
                    CD_LetraCReal = dados.CaracteristicasDominantes.CD_LetraCReal,
                    CD_LetraDExpect = dados.CaracteristicasDominantes.CD_LetraDExpect,
                    CD_LetraDReal = dados.CaracteristicasDominantes.CD_LetraDReal
                },

                GestaoDeFuncionarios = new GestaoDeFuncionariosViewModel
                {
                    GF_LetraAExpect = dados.GestaoDeFuncionarios.GF_LetraAExpect,
                    GF_LetraAReal = dados.GestaoDeFuncionarios.GF_LetraAReal,
                    GF_LetraBExpect = dados.GestaoDeFuncionarios.GF_LetraBExpect,
                    GF_LetraBReal = dados.GestaoDeFuncionarios.GF_LetraBReal,
                    GF_LetraCExpect = dados.GestaoDeFuncionarios.GF_LetraCExpect,
                    GF_LetraCReal = dados.GestaoDeFuncionarios.GF_LetraCReal,
                    GF_LetraDExpect = dados.GestaoDeFuncionarios.GF_LetraDExpect,
                    GF_LetraDReal = dados.GestaoDeFuncionarios.GF_LetraDReal
                },

                ColagemDeOrganizacao = new ColagemDeOrganizacaoViewModel
                {
                    CO_LetraAExpect = dados.ColagemDeOrganizacao.CO_LetraAExpect,
                    CO_LetraAReal = dados.ColagemDeOrganizacao.CO_LetraAReal,
                    CO_LetraBExpect = dados.ColagemDeOrganizacao.CO_LetraBExpect,
                    CO_LetraBReal = dados.ColagemDeOrganizacao.CO_LetraBReal,
                    CO_LetraCExpect = dados.ColagemDeOrganizacao.CO_LetraCExpect,
                    CO_LetraCReal = dados.ColagemDeOrganizacao.CO_LetraCReal,
                    CO_LetraDExpect = dados.ColagemDeOrganizacao.CO_LetraDExpect,
                    CO_LetraDReal = dados.ColagemDeOrganizacao.CO_LetraDReal
                },

                LiderancaOrganizacional = new LiderancaOrganizacionalViewModel
                {
                    LO_LetraAExpect = dados.LiderancaOrganizacional.LO_LetraAExpect,
                    LO_LetraAReal = dados.LiderancaOrganizacional.LO_LetraAReal,
                    LO_LetraBExpect = dados.LiderancaOrganizacional.LO_LetraBExpect,
                    LO_LetraBReal = dados.LiderancaOrganizacional.LO_LetraBReal,
                    LO_LetraCExpect = dados.LiderancaOrganizacional.LO_LetraCExpect,
                    LO_LetraCReal = dados.LiderancaOrganizacional.LO_LetraCReal,
                    LO_LetraDExpect = dados.LiderancaOrganizacional.LO_LetraDExpect,
                    LO_LetraDReal = dados.LiderancaOrganizacional.LO_LetraDReal
                },

                EnfaseEstrategica = new EnfaseEstrategicaViewModel
                {
                    EE_LetraAExpect = dados.EnfaseEstrategica.EE_LetraAExpect,
                    EE_LetraAReal = dados.EnfaseEstrategica.EE_LetraAReal,
                    EE_LetraBExpect = dados.EnfaseEstrategica.EE_LetraBExpect,
                    EE_LetraBReal = dados.EnfaseEstrategica.EE_LetraBReal,
                    EE_LetraCExpect = dados.EnfaseEstrategica.EE_LetraCExpect,
                    EE_LetraCReal = dados.EnfaseEstrategica.EE_LetraCReal,
                    EE_LetraDExpect = dados.EnfaseEstrategica.EE_LetraDExpect,
                    EE_LetraDReal = dados.EnfaseEstrategica.EE_LetraDReal
                },

                CriteriosDeSucesso = new CriteriosDeSucessoViewModel
                {
                    CS_LetraAExpect = dados.CriteriosDeSucesso.CS_LetraAExpect,
                    CS_LetraAReal = dados.CriteriosDeSucesso.CS_LetraAReal,
                    CS_LetraBExpect = dados.CriteriosDeSucesso.CS_LetraBExpect,
                    CS_LetraBReal = dados.CriteriosDeSucesso.CS_LetraBReal,
                    CS_LetraCExpect = dados.CriteriosDeSucesso.CS_LetraCExpect,
                    CS_LetraCReal = dados.CriteriosDeSucesso.CS_LetraCReal,
                    CS_LetraDExpect = dados.CriteriosDeSucesso.CS_LetraDExpect,
                    CS_LetraDReal = dados.CriteriosDeSucesso.CS_LetraDReal
                }
            };

            return dadosPesquisa;
        }

    }
}
