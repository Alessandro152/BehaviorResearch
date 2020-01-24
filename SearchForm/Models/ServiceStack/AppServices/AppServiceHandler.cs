
using SearchForm.Models.QueryStack.Interface;
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

        public void SalvarRespostas(DadosPesquisaViewModel dados)
        {
            _repo.SalvarRespostas(dados);
        }

        public void SalvarBarrettValues(BarrettValuesViewModel barrettValues)
        {
            _repo.SalvarBarrettValues(barrettValues);
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

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
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

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
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

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
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

                resultado = SomarValores(LetraAExpect, LetraAReal, LetraBExpect, LetraBReal, LetraCExpect, LetraCReal, LetraDExpect, LetraDReal);

                if (resultado != VALOR_CAMPO_EXPECTATIVA_REALIDADE)
                {
                    return true;
                }
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
    }
}
