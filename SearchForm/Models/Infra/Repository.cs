using MySql.Data.MySqlClient;
using SearchForm.Models.QueryStack.Interface;
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;
using System;
using System.Data;
using System.Threading.Tasks;

namespace SearchForm.Models.Infra
{
    public class Repository : IRepository
    {
        private MySqlConnection connect;

        public MySqlConnection DatabaseConnection { get; private set; }

        public Task<bool> SalvarPesquisa(BarrettValuesViewModel dados, DadosPesquisaViewModel pesquisa)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = ConectarBanco();

                if (DatabaseConnection.State != ConnectionState.Open) return Task.FromResult(false);

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO PESSOA VALUES(?, ?, ?)";
                Comm.Parameters.AddWithValue("@NOME", pesquisa.Funcionario.Nome);
                Comm.Parameters.AddWithValue("@DEPARTAMENTO", pesquisa.Funcionario.Departamento);
                Comm.Parameters.AddWithValue("@CARGO", pesquisa.Funcionario.Cargo);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO CARACTERISTICASDOMINANTES VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
                Comm.Parameters.AddWithValue("@CD_A_EXPECT", pesquisa.CaracteristicasDominantes.CD_LetraAExpect);
                Comm.Parameters.AddWithValue("@CD_A_REAL", pesquisa.CaracteristicasDominantes.CD_LetraAReal);
                Comm.Parameters.AddWithValue("@CD_B_EXPECT", pesquisa.CaracteristicasDominantes.CD_LetraBExpect);
                Comm.Parameters.AddWithValue("@CD_B_REAL", pesquisa.CaracteristicasDominantes.CD_LetraBReal);
                Comm.Parameters.AddWithValue("@CD_C_EXPECT", pesquisa.CaracteristicasDominantes.CD_LetraCExpect);
                Comm.Parameters.AddWithValue("@CD_C_REAL", pesquisa.CaracteristicasDominantes.CD_LetraCReal);
                Comm.Parameters.AddWithValue("@CD_D_EXPECT", pesquisa.CaracteristicasDominantes.CD_LetraDExpect);
                Comm.Parameters.AddWithValue("@CD_D_REAL", pesquisa.CaracteristicasDominantes.CD_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO LIDERANCAORGANIZACIONAL VALUES(@LO_A_EXPECT, @LO_A_REAL, @LO_B_EXPECT, @LO_B_REAL, @LO_C_EXPECT, @LO_C_REAL, @LO_D_EXPECT, @LO_D_REAL)";
                Comm.Parameters.AddWithValue("@LO_A_EXPECT", pesquisa.LiderancaOrganizacional.LO_LetraAExpect);
                Comm.Parameters.AddWithValue("@LO_A_REAL", pesquisa.LiderancaOrganizacional.LO_LetraAReal);
                Comm.Parameters.AddWithValue("@LO_B_EXPECT", pesquisa.LiderancaOrganizacional.LO_LetraBExpect);
                Comm.Parameters.AddWithValue("@LO_B_REAL", pesquisa.LiderancaOrganizacional.LO_LetraBReal);
                Comm.Parameters.AddWithValue("@LO_C_EXPECT", pesquisa.LiderancaOrganizacional.LO_LetraCExpect);
                Comm.Parameters.AddWithValue("@LO_C_REAL", pesquisa.LiderancaOrganizacional.LO_LetraCReal);
                Comm.Parameters.AddWithValue("@LO_D_EXPECT", pesquisa.LiderancaOrganizacional.LO_LetraDExpect);
                Comm.Parameters.AddWithValue("@LO_D_REAL", pesquisa.LiderancaOrganizacional.LO_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO GESTAODEFUNCIONARIOS VALUES(@GF_A_EXPECT, @GF_A_REAL, @GF_B_EXPECT, @GF_B_REAL, @GF_C_EXPECT, @GF_C_REAL, @GF_D_EXPECT, @GF_D_REAL)";
                Comm.Parameters.AddWithValue("@GF_A_EXPECT", pesquisa.GestaoDeFuncionarios.GF_LetraAExpect);
                Comm.Parameters.AddWithValue("@GF_A_REAL", pesquisa.GestaoDeFuncionarios.GF_LetraAReal);
                Comm.Parameters.AddWithValue("@GF_B_EXPECT", pesquisa.GestaoDeFuncionarios.GF_LetraBExpect);
                Comm.Parameters.AddWithValue("@GF_B_REAL", pesquisa.GestaoDeFuncionarios.GF_LetraBReal);
                Comm.Parameters.AddWithValue("@GF_C_EXPECT", pesquisa.GestaoDeFuncionarios.GF_LetraCExpect);
                Comm.Parameters.AddWithValue("@GF_C_REAL", pesquisa.GestaoDeFuncionarios.GF_LetraCReal);
                Comm.Parameters.AddWithValue("@GF_D_EXPECT", pesquisa.GestaoDeFuncionarios.GF_LetraDExpect);
                Comm.Parameters.AddWithValue("@GF_D_REAL", pesquisa.GestaoDeFuncionarios.GF_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO COLAGEMDEORGANIZACAO VALUES(@CO_A_EXPECT, @CO_A_REAL, @CO_B_EXPECT, @CO_B_REAL, @CO_C_EXPECT, @CO_C_REAL, @CO_D_EXPECT, @CO_D_REAL)";
                Comm.Parameters.AddWithValue("@CO_A_EXPECT", pesquisa.ColagemDeOrganizacao.CO_LetraAExpect);
                Comm.Parameters.AddWithValue("@CO_A_REAL", pesquisa.ColagemDeOrganizacao.CO_LetraAReal);
                Comm.Parameters.AddWithValue("@CO_B_EXPECT", pesquisa.ColagemDeOrganizacao.CO_LetraBExpect);
                Comm.Parameters.AddWithValue("@CO_B_REAL", pesquisa.ColagemDeOrganizacao.CO_LetraBReal);
                Comm.Parameters.AddWithValue("@CO_C_EXPECT", pesquisa.ColagemDeOrganizacao.CO_LetraCExpect);
                Comm.Parameters.AddWithValue("@CO_C_REAL", pesquisa.ColagemDeOrganizacao.CO_LetraCReal);
                Comm.Parameters.AddWithValue("@CO_D_EXPECT", pesquisa.ColagemDeOrganizacao.CO_LetraDExpect);
                Comm.Parameters.AddWithValue("@CO_D_REAL", pesquisa.ColagemDeOrganizacao.CO_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO ENFASEESTRATEGICA VALUES(@EE_A_EXPECT, @EE_A_REAL, @EE_B_EXPECT, @EE_B_REAL, @EE_C_EXPECT, @EE_C_REAL, @EE_D_EXPECT, @EE_D_REAL)";
                Comm.Parameters.AddWithValue("@EE_A_EXPECT", pesquisa.EnfaseEstrategica.EE_LetraAExpect);
                Comm.Parameters.AddWithValue("@EE_A_REAL", pesquisa.EnfaseEstrategica.EE_LetraAReal);
                Comm.Parameters.AddWithValue("@EE_B_EXPECT", pesquisa.EnfaseEstrategica.EE_LetraBExpect);
                Comm.Parameters.AddWithValue("@EE_B_REAL", pesquisa.EnfaseEstrategica.EE_LetraBReal);
                Comm.Parameters.AddWithValue("@EE_C_EXPECT", pesquisa.EnfaseEstrategica.EE_LetraCExpect);
                Comm.Parameters.AddWithValue("@EE_C_REAL", pesquisa.EnfaseEstrategica.EE_LetraCReal);
                Comm.Parameters.AddWithValue("@EE_D_EXPECT", pesquisa.EnfaseEstrategica.EE_LetraDExpect);
                Comm.Parameters.AddWithValue("@EE_D_REAL", pesquisa.EnfaseEstrategica.EE_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO CRITERIOSDESUCESSO VALUES(@CS_A_EXPECT, @CS_A_REAL, @CS_B_EXPECT, @CS_B_REAL, @CS_C_EXPECT, @CS_C_REAL, @CS_D_EXPECT, @CS_D_REAL)";
                Comm.Parameters.AddWithValue("@CS_A_EXPECT", pesquisa.CriteriosDeSucesso.CS_LetraAExpect);
                Comm.Parameters.AddWithValue("@CS_A_REAL", pesquisa.CriteriosDeSucesso.CS_LetraAReal);
                Comm.Parameters.AddWithValue("@CS_B_EXPECT", pesquisa.CriteriosDeSucesso.CS_LetraBExpect);
                Comm.Parameters.AddWithValue("@CS_B_REAL", pesquisa.CriteriosDeSucesso.CS_LetraBReal);
                Comm.Parameters.AddWithValue("@CS_C_EXPECT", pesquisa.CriteriosDeSucesso.CS_LetraCExpect);
                Comm.Parameters.AddWithValue("@CS_C_REAL", pesquisa.CriteriosDeSucesso.CS_LetraCReal);
                Comm.Parameters.AddWithValue("@CS_D_EXPECT", pesquisa.CriteriosDeSucesso.CS_LetraDExpect);
                Comm.Parameters.AddWithValue("@CS_D_REAL", pesquisa.CriteriosDeSucesso.CS_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO BARRETTVALUES VALUES(@SENSO_DE_DONO, @ATINGIR_OBJETIVOS, @ADAPTABILIDADE, @EQUILIBRIO, @SER_O_MELHOR, @CULPAR, @IMAGEM_DA_MARCA, @BUROCRACIA, @IMPORTAR_SE, @CAUTELA," +
                                    "@CLAREZA, @COACHING, @COMPROMETIMENTO, @ENVOLVIMENTO_COMUNITARIO, @COMPAIXAO, @SOLUCAO_DE_CONFLITOS, @CONFUSAO, @MELHORIA_CONTINUA, @APRENDIZAGEM_CONTINUA, @CONTROLE, " +
                                    "@COOPERACAO, @REDUCAO_DE_CUSTOS, @CORAGEM, @CRIATIVIDADE, @COLABORACAO_ENTRE_GRUPOS, @CURIOSIDADE, @COLABORACAO_COM_O_CLIENTE, @SATISFACAO_DO_CLIENTE, @CONFORTO_COM_INCERTEZAS, @EFICIENCIA, " +
                                    "@VALORIZANDO_A_DIVERSIDADE, @EXPANDIR_PODER, @ENGAJAMENTO_DOS_FUNCIONARIOS, @REALIZACAO_DO_FUNCIONARIO, @SAUDE_DO_FUNCIONARIO, @RECONHECIMENTO_DOS_FUNCIONARIOS, @EMPODERAR, @ENCORAJAMENTO, @ENTUSIASMO, @EMPREENDEDORISMO, " +
                                    "@CONSCIENCIA_AMBIENTAL, @IGUALDADE, @EXCELENCIA, @EXPERIENCIA, @EXPLORACAO, @IMPARCIALIDADE, @ESTABILIDADE_FINANCEIRA, @PERDAO, @PREOCUPACAO_COM_FUTURAS_GERACOES, " +
                                    "@LIDERANCA_GLOBAL, @ORIENTADO_PARA_OBJETIVOS, @HIERARQUIA, @PENSAMENTO_HOLISTICO, @HONESTIDADE, @DIREITOS_HUMANOS, @HUMOR_ALEGRIA, @CAPACIDADE_DE_INCLUSAO, @RETER_INFORMACOES, @COMPARTILHAR_INFORMACOES, " +
                                    "@INICIATIVA, @INOVACAO, @INTEGRIDADE, @COMPETICAO_INTERNA, @INSEGURANCA_DO_EMPREGO, @DESENVOLVIMENTO_DA_LIDERANCA, @LIDERANDO_PELO_EXEMPLO, @ESCUTAR, @TRABALHO_EXCESSIVO, @PERSPECTIVA_DE_LONGO_PRAZO, " +
                                    "@FAZER_A_DIFERENCA, @MANIPULACAO, @FOCO_NA_MISSAO, @COMUNICACAO_ABERTA, @ABERTURA)";
                Comm.Parameters.AddWithValue("@SENSO_DE_DONO", dados.SensoDeDono);
                Comm.Parameters.AddWithValue("@ATINGIR_OBJETIVOS", dados.AtingirObjetivos);
                Comm.Parameters.AddWithValue("@ADAPTABILIDADE", dados.Adaptabilidade);
                Comm.Parameters.AddWithValue("@EQUILIBRIO", dados.Equilibrio);
                Comm.Parameters.AddWithValue("@SER_O_MELHOR", dados.SerOMelhor);
                Comm.Parameters.AddWithValue("@CULPAR", dados.Culpar);
                Comm.Parameters.AddWithValue("@IMAGEM_DA_MARCA", dados.ImagemDaMarca);
                Comm.Parameters.AddWithValue("@BUROCRACIA", dados.Burocracia);
                Comm.Parameters.AddWithValue("@IMPORTAR_SE", dados.ImportarSe);
                Comm.Parameters.AddWithValue("@CAUTELA", dados.Cautela);
                Comm.Parameters.AddWithValue("@CLAREZA", dados.Clareza);
                Comm.Parameters.AddWithValue("@COACHING", dados.Coaching);
                Comm.Parameters.AddWithValue("@COMPROMETIMENTO", dados.Comprometimento);
                Comm.Parameters.AddWithValue("@ENVOLVIMENTO_COMUNITARIO", dados.EnvolvimentoComunitario);
                Comm.Parameters.AddWithValue("@COMPAIXAO", dados.Compaixao);
                Comm.Parameters.AddWithValue("@SOLUCAO_DE_CONFLITOS", dados.SolucaoDeConflitos);
                Comm.Parameters.AddWithValue("@CONFUSAO", dados.Confusao);
                Comm.Parameters.AddWithValue("@MELHORIA_CONTINUA", dados.MelhoriaContinua);
                Comm.Parameters.AddWithValue("@APRENDIZAGEM_CONTINUA", dados.AprendizagemContinua);
                Comm.Parameters.AddWithValue("@CONTROLE", dados.Controle);
                Comm.Parameters.AddWithValue("@COOPERACAO", dados.Cooperacao);
                Comm.Parameters.AddWithValue("@REDUCAO_DE_CUSTOS", dados.ReducaoDeCustos);
                Comm.Parameters.AddWithValue("@CORAGEM", dados.Coragem);
                Comm.Parameters.AddWithValue("@CRIATIVIDADE", dados.Criatividade);
                Comm.Parameters.AddWithValue("@COLABORACAO_ENTRE_GRUPOS", dados.ColaboracaoEntreGrupos);
                Comm.Parameters.AddWithValue("@CURIOSIDADE", dados.Curiosidade);
                Comm.Parameters.AddWithValue("@COLABORACAO_COM_O_CLIENTE", dados.ColaboracaoComCliente);
                Comm.Parameters.AddWithValue("@SATISFACAO_DO_CLIENTE", dados.SatisfacaoDoCliente);
                Comm.Parameters.AddWithValue("@CONFORTO_COM_INCERTEZAS", dados.ConfortoComIncertezas);
                Comm.Parameters.AddWithValue("@EFICIENCIA", dados.Eficiencia);
                Comm.Parameters.AddWithValue("@VALORIZANDO_A_DIVERSIDADE", dados.ValorizandoADiversidade);
                Comm.Parameters.AddWithValue("@EXPANDIR_PODER", dados.ExpandirPoder);
                Comm.Parameters.AddWithValue("@ENGAJAMENTO_DOS_FUNCIONARIOS", dados.EngajamentoDosFuncionarios);
                Comm.Parameters.AddWithValue("@REALIZACAO_DO_FUNCIONARIO", dados.RealizacaoDoFuncionario);
                Comm.Parameters.AddWithValue("@SAUDE_DO_FUNCIONARIO", dados.SaudeDoFuncionario);
                Comm.Parameters.AddWithValue("@RECONHECIMENTO_DOS_FUNCIONARIOS", dados.ReconhecimentoDoFuncionario);
                Comm.Parameters.AddWithValue("@EMPODERAR", dados.Empoderar);
                Comm.Parameters.AddWithValue("@ENCORAJAMENTO", dados.Encorajamento);
                Comm.Parameters.AddWithValue("@ENTUSIASMO", dados.Entusiasmo);
                Comm.Parameters.AddWithValue("@EMPREENDEDORISMO", dados.Empreendedorismo);
                Comm.Parameters.AddWithValue("@CONSCIENCIA_AMBIENTAL", dados.ConscienciaAmbiental);
                Comm.Parameters.AddWithValue("@IGUALDADE", dados.Igualdade);
                Comm.Parameters.AddWithValue("@EXCELENCIA", dados.Excelencia);
                Comm.Parameters.AddWithValue("@EXPERIENCIA", dados.Experiencia);
                Comm.Parameters.AddWithValue("@EXPLORACAO", dados.Exploracao);
                Comm.Parameters.AddWithValue("@IMPARCIALIDADE", dados.Imparcialidade);
                Comm.Parameters.AddWithValue("@ESTABILIDADE_FINANCEIRA", dados.EstabilidadeFinanceira);
                Comm.Parameters.AddWithValue("@PERDAO", dados.Perdao);
                Comm.Parameters.AddWithValue("@PREOCUPACAO_COM_FUTURAS_GERACOES", dados.PreocupacaoComFuturasGeracoes);
                Comm.Parameters.AddWithValue("@LIDERANCA_GLOBAL", dados.LiderancaGlobal);
                Comm.Parameters.AddWithValue("@ORIENTADO_PARA_OBJETIVOS", dados.OrientadoParaObjetivos);
                Comm.Parameters.AddWithValue("@HIERARQUIA", dados.Hierarquia);
                Comm.Parameters.AddWithValue("@PENSAMENTO_HOLISTICO", dados.PensamentoHolistico);
                Comm.Parameters.AddWithValue("@HONESTIDADE", dados.Honestidade);
                Comm.Parameters.AddWithValue("@DIREITOS_HUMANOS", dados.DireitosHumanos);
                Comm.Parameters.AddWithValue("@HUMOR_ALEGRIA", dados.HumorAlegria);
                Comm.Parameters.AddWithValue("@CAPACIDADE_DE_INCLUSAO", dados.CapacidadeDeInclusao);
                Comm.Parameters.AddWithValue("@RETER_INFORMACOES", dados.ReterInformacoes);
                Comm.Parameters.AddWithValue("@COMPARTILHAR_INFORMACOES", dados.CompartilharInformacoes);
                Comm.Parameters.AddWithValue("@INICIATIVA", dados.Iniciativa);
                Comm.Parameters.AddWithValue("@INOVACAO", dados.Inovacao);
                Comm.Parameters.AddWithValue("@INTEGRIDADE", dados.Integridade);
                Comm.Parameters.AddWithValue("@COMPETICAO_INTERNA", dados.CompeticaoInterna);
                Comm.Parameters.AddWithValue("@INSEGURANCA_DO_EMPREGO", dados.InsegurancaDoEmprego);
                Comm.Parameters.AddWithValue("@DESENVOLVIMENTO_DA_LIDERANCA", dados.DesenvolvimentoDaLideranca);
                Comm.Parameters.AddWithValue("@LIDERANDO_PELO_EXEMPLO", dados.LiderandoPeloExemplo);
                Comm.Parameters.AddWithValue("@ESCUTAR", dados.Escutar);
                Comm.Parameters.AddWithValue("@TRABALHO_EXCESSIVO", dados.TrabalhoExcessivo);
                Comm.Parameters.AddWithValue("@PERSPECTIVA_DE_LONGO_PRAZO", dados.PerspectivaDeLongoPrazo);
                Comm.Parameters.AddWithValue("@FAZER_A_DIFERENCA", dados.FazerADiferenca);
                Comm.Parameters.AddWithValue("@MANIPULACAO", dados.Manipulacao);
                Comm.Parameters.AddWithValue("@FOCO_NA_MISSAO", dados.FocoNaMissao);
                Comm.Parameters.AddWithValue("@COMUNICACAO_ABERTA", dados.ComunicaoAberta);
                Comm.Parameters.AddWithValue("@ABERTURA", dados.Abertura);

                Comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (DatabaseConnection.State == ConnectionState.Open)
                {
                    DatabaseConnection.Dispose();
                }
            }

            return Task.FromResult(true);
        }

        private MySqlConnection ConectarBanco()
        {
            const string Connection = "server=localhost;uid=root;pwd=1234;";

            try

            {
                connect = new MySqlConnection
                {
                    ConnectionString = Connection
                };

                connect.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return connect;
        }
    }
}