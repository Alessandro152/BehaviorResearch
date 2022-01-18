namespace SearchForm.Models.Infra
{
    using MySql.Data.MySqlClient;
    using SearchForm.Models.Entites.Common;
    using SearchForm.Models.Domain.Interface;
    using System;
    using System.Data;
    using System.Threading.Tasks;
    using System.Configuration;
    using Microsoft.Extensions.Configuration;

    public class Repository : IRepository
    {
        private readonly IConfiguration _configuration;
        private MySqlConnection _databaseConnection;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> SalvarPesquisa(PesquisaModel pesquisa)
        {
            try
            {
                _databaseConnection = ConectarBanco();

                if (_databaseConnection.State != ConnectionState.Open) return Task.FromResult(false);

                var commandSql = _databaseConnection.CreateCommand();

                commandSql.CommandText = "USE FORMULARIO";
                commandSql.ExecuteNonQuery();

                commandSql.CommandText = "INSERT INTO PESSOA VALUES(@NOME, @DEPARTAMENTO, @CARGO)";
                commandSql.Parameters.AddWithValue("@NOME", pesquisa.Nome);
                commandSql.Parameters.AddWithValue("@DEPARTAMENTO", pesquisa.Departamento);
                commandSql.Parameters.AddWithValue("@CARGO", pesquisa.Cargo);
                commandSql.ExecuteNonQuery();
                commandSql.Parameters.Clear();

                commandSql.CommandText = "INSERT INTO CARACTERISTICASDOMINANTES VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
                commandSql.Parameters.AddWithValue("@CD_A_EXPECT", pesquisa.CaracteristicasDominantes.CD_LetraAExpect);
                commandSql.Parameters.AddWithValue("@CD_A_REAL", pesquisa.CaracteristicasDominantes.CD_LetraAReal);
                commandSql.Parameters.AddWithValue("@CD_B_EXPECT", pesquisa.CaracteristicasDominantes.CD_LetraBExpect);
                commandSql.Parameters.AddWithValue("@CD_B_REAL", pesquisa.CaracteristicasDominantes.CD_LetraBReal);
                commandSql.Parameters.AddWithValue("@CD_C_EXPECT", pesquisa.CaracteristicasDominantes.CD_LetraCExpect);
                commandSql.Parameters.AddWithValue("@CD_C_REAL", pesquisa.CaracteristicasDominantes.CD_LetraCReal);
                commandSql.Parameters.AddWithValue("@CD_D_EXPECT", pesquisa.CaracteristicasDominantes.CD_LetraDExpect);
                commandSql.Parameters.AddWithValue("@CD_D_REAL", pesquisa.CaracteristicasDominantes.CD_LetraDReal);
                commandSql.ExecuteNonQuery();
                commandSql.Parameters.Clear();

                commandSql.CommandText = "INSERT INTO LIDERANCAORGANIZACIONAL VALUES(@LO_A_EXPECT, @LO_A_REAL, @LO_B_EXPECT, @LO_B_REAL, @LO_C_EXPECT, @LO_C_REAL, @LO_D_EXPECT, @LO_D_REAL)";
                commandSql.Parameters.AddWithValue("@LO_A_EXPECT", pesquisa.LiderancaOrganizacional.LO_LetraAExpect);
                commandSql.Parameters.AddWithValue("@LO_A_REAL", pesquisa.LiderancaOrganizacional.LO_LetraAReal);
                commandSql.Parameters.AddWithValue("@LO_B_EXPECT", pesquisa.LiderancaOrganizacional.LO_LetraBExpect);
                commandSql.Parameters.AddWithValue("@LO_B_REAL", pesquisa.LiderancaOrganizacional.LO_LetraBReal);
                commandSql.Parameters.AddWithValue("@LO_C_EXPECT", pesquisa.LiderancaOrganizacional.LO_LetraCExpect);
                commandSql.Parameters.AddWithValue("@LO_C_REAL", pesquisa.LiderancaOrganizacional.LO_LetraCReal);
                commandSql.Parameters.AddWithValue("@LO_D_EXPECT", pesquisa.LiderancaOrganizacional.LO_LetraDExpect);
                commandSql.Parameters.AddWithValue("@LO_D_REAL", pesquisa.LiderancaOrganizacional.LO_LetraDReal);
                commandSql.ExecuteNonQuery();
                commandSql.Parameters.Clear();

                commandSql.CommandText = "INSERT INTO GESTAODEFUNCIONARIOS VALUES(@GF_A_EXPECT, @GF_A_REAL, @GF_B_EXPECT, @GF_B_REAL, @GF_C_EXPECT, @GF_C_REAL, @GF_D_EXPECT, @GF_D_REAL)";
                commandSql.Parameters.AddWithValue("@GF_A_EXPECT", pesquisa.GestaoDeFuncionarios.GF_LetraAExpect);
                commandSql.Parameters.AddWithValue("@GF_A_REAL", pesquisa.GestaoDeFuncionarios.GF_LetraAReal);
                commandSql.Parameters.AddWithValue("@GF_B_EXPECT", pesquisa.GestaoDeFuncionarios.GF_LetraBExpect);
                commandSql.Parameters.AddWithValue("@GF_B_REAL", pesquisa.GestaoDeFuncionarios.GF_LetraBReal);
                commandSql.Parameters.AddWithValue("@GF_C_EXPECT", pesquisa.GestaoDeFuncionarios.GF_LetraCExpect);
                commandSql.Parameters.AddWithValue("@GF_C_REAL", pesquisa.GestaoDeFuncionarios.GF_LetraCReal);
                commandSql.Parameters.AddWithValue("@GF_D_EXPECT", pesquisa.GestaoDeFuncionarios.GF_LetraDExpect);
                commandSql.Parameters.AddWithValue("@GF_D_REAL", pesquisa.GestaoDeFuncionarios.GF_LetraDReal);
                commandSql.ExecuteNonQuery();
                commandSql.Parameters.Clear();

                commandSql.CommandText = "INSERT INTO COLAGEMDEORGANIZACAO VALUES(@CO_A_EXPECT, @CO_A_REAL, @CO_B_EXPECT, @CO_B_REAL, @CO_C_EXPECT, @CO_C_REAL, @CO_D_EXPECT, @CO_D_REAL)";
                commandSql.Parameters.AddWithValue("@CO_A_EXPECT", pesquisa.ColagemDeOrganizacao.CO_LetraAExpect);
                commandSql.Parameters.AddWithValue("@CO_A_REAL", pesquisa.ColagemDeOrganizacao.CO_LetraAReal);
                commandSql.Parameters.AddWithValue("@CO_B_EXPECT", pesquisa.ColagemDeOrganizacao.CO_LetraBExpect);
                commandSql.Parameters.AddWithValue("@CO_B_REAL", pesquisa.ColagemDeOrganizacao.CO_LetraBReal);
                commandSql.Parameters.AddWithValue("@CO_C_EXPECT", pesquisa.ColagemDeOrganizacao.CO_LetraCExpect);
                commandSql.Parameters.AddWithValue("@CO_C_REAL", pesquisa.ColagemDeOrganizacao.CO_LetraCReal);
                commandSql.Parameters.AddWithValue("@CO_D_EXPECT", pesquisa.ColagemDeOrganizacao.CO_LetraDExpect);
                commandSql.Parameters.AddWithValue("@CO_D_REAL", pesquisa.ColagemDeOrganizacao.CO_LetraDReal);
                commandSql.ExecuteNonQuery();
                commandSql.Parameters.Clear();

                commandSql.CommandText = "INSERT INTO ENFASEESTRATEGICA VALUES(@EE_A_EXPECT, @EE_A_REAL, @EE_B_EXPECT, @EE_B_REAL, @EE_C_EXPECT, @EE_C_REAL, @EE_D_EXPECT, @EE_D_REAL)";
                commandSql.Parameters.AddWithValue("@EE_A_EXPECT", pesquisa.EnfaseEstrategica.EE_LetraAExpect);
                commandSql.Parameters.AddWithValue("@EE_A_REAL", pesquisa.EnfaseEstrategica.EE_LetraAReal);
                commandSql.Parameters.AddWithValue("@EE_B_EXPECT", pesquisa.EnfaseEstrategica.EE_LetraBExpect);
                commandSql.Parameters.AddWithValue("@EE_B_REAL", pesquisa.EnfaseEstrategica.EE_LetraBReal);
                commandSql.Parameters.AddWithValue("@EE_C_EXPECT", pesquisa.EnfaseEstrategica.EE_LetraCExpect);
                commandSql.Parameters.AddWithValue("@EE_C_REAL", pesquisa.EnfaseEstrategica.EE_LetraCReal);
                commandSql.Parameters.AddWithValue("@EE_D_EXPECT", pesquisa.EnfaseEstrategica.EE_LetraDExpect);
                commandSql.Parameters.AddWithValue("@EE_D_REAL", pesquisa.EnfaseEstrategica.EE_LetraDReal);
                commandSql.ExecuteNonQuery();
                commandSql.Parameters.Clear();

                commandSql.CommandText = "INSERT INTO CRITERIOSDESUCESSO VALUES(@CS_A_EXPECT, @CS_A_REAL, @CS_B_EXPECT, @CS_B_REAL, @CS_C_EXPECT, @CS_C_REAL, @CS_D_EXPECT, @CS_D_REAL)";
                commandSql.Parameters.AddWithValue("@CS_A_EXPECT", pesquisa.CriteriosDeSucesso.CS_LetraAExpect);
                commandSql.Parameters.AddWithValue("@CS_A_REAL", pesquisa.CriteriosDeSucesso.CS_LetraAReal);
                commandSql.Parameters.AddWithValue("@CS_B_EXPECT", pesquisa.CriteriosDeSucesso.CS_LetraBExpect);
                commandSql.Parameters.AddWithValue("@CS_B_REAL", pesquisa.CriteriosDeSucesso.CS_LetraBReal);
                commandSql.Parameters.AddWithValue("@CS_C_EXPECT", pesquisa.CriteriosDeSucesso.CS_LetraCExpect);
                commandSql.Parameters.AddWithValue("@CS_C_REAL", pesquisa.CriteriosDeSucesso.CS_LetraCReal);
                commandSql.Parameters.AddWithValue("@CS_D_EXPECT", pesquisa.CriteriosDeSucesso.CS_LetraDExpect);
                commandSql.Parameters.AddWithValue("@CS_D_REAL", pesquisa.CriteriosDeSucesso.CS_LetraDReal);
                commandSql.ExecuteNonQuery();
                commandSql.Parameters.Clear();

                commandSql.CommandText = "INSERT INTO BARRETTVALUES VALUES(@SENSO_DE_DONO, @ATINGIR_OBJETIVOS, @ADAPTABILIDADE, @EQUILIBRIO, @SER_O_MELHOR, @CULPAR, @IMAGEM_DA_MARCA, @BUROCRACIA, @IMPORTAR_SE, @CAUTELA," +
                                    "@CLAREZA, @COACHING, @COMPROMETIMENTO, @ENVOLVIMENTO_COMUNITARIO, @COMPAIXAO, @SOLUCAO_DE_CONFLITOS, @CONFUSAO, @MELHORIA_CONTINUA, @APRENDIZAGEM_CONTINUA, @CONTROLE, " +
                                    "@COOPERACAO, @REDUCAO_DE_CUSTOS, @CORAGEM, @CRIATIVIDADE, @COLABORACAO_ENTRE_GRUPOS, @CURIOSIDADE, @COLABORACAO_COM_O_CLIENTE, @SATISFACAO_DO_CLIENTE, @CONFORTO_COM_INCERTEZAS, @EFICIENCIA, " +
                                    "@VALORIZANDO_A_DIVERSIDADE, @EXPANDIR_PODER, @ENGAJAMENTO_DOS_FUNCIONARIOS, @REALIZACAO_DO_FUNCIONARIO, @SAUDE_DO_FUNCIONARIO, @RECONHECIMENTO_DOS_FUNCIONARIOS, @EMPODERAR, @ENCORAJAMENTO, @ENTUSIASMO, @EMPREENDEDORISMO, " +
                                    "@CONSCIENCIA_AMBIENTAL, @IGUALDADE, @EXCELENCIA, @EXPERIENCIA, @EXPLORACAO, @IMPARCIALIDADE, @ESTABILIDADE_FINANCEIRA, @PERDAO, @PREOCUPACAO_COM_FUTURAS_GERACOES, " +
                                    "@LIDERANCA_GLOBAL, @ORIENTADO_PARA_OBJETIVOS, @HIERARQUIA, @PENSAMENTO_HOLISTICO, @HONESTIDADE, @DIREITOS_HUMANOS, @HUMOR_ALEGRIA, @CAPACIDADE_DE_INCLUSAO, @RETER_INFORMACOES, @COMPARTILHAR_INFORMACOES, " +
                                    "@INICIATIVA, @INOVACAO, @INTEGRIDADE, @COMPETICAO_INTERNA, @INSEGURANCA_DO_EMPREGO, @DESENVOLVIMENTO_DA_LIDERANCA, @LIDERANDO_PELO_EXEMPLO, @ESCUTAR, @TRABALHO_EXCESSIVO, @PERSPECTIVA_DE_LONGO_PRAZO, " +
                                    "@FAZER_A_DIFERENCA, @MANIPULACAO, @FOCO_NA_MISSAO, @COMUNICACAO_ABERTA, @ABERTURA)";
                commandSql.Parameters.AddWithValue("@SENSO_DE_DONO", pesquisa.BarrettValues.SensoDeDono);
                commandSql.Parameters.AddWithValue("@ATINGIR_OBJETIVOS", pesquisa.BarrettValues.AtingirObjetivos);
                commandSql.Parameters.AddWithValue("@ADAPTABILIDADE", pesquisa.BarrettValues.Adaptabilidade);
                commandSql.Parameters.AddWithValue("@EQUILIBRIO", pesquisa.BarrettValues.Equilibrio);
                commandSql.Parameters.AddWithValue("@SER_O_MELHOR", pesquisa.BarrettValues.SerOMelhor);
                commandSql.Parameters.AddWithValue("@CULPAR", pesquisa.BarrettValues.Culpar);
                commandSql.Parameters.AddWithValue("@IMAGEM_DA_MARCA", pesquisa.BarrettValues.ImagemDaMarca);
                commandSql.Parameters.AddWithValue("@BUROCRACIA", pesquisa.BarrettValues.Burocracia);
                commandSql.Parameters.AddWithValue("@IMPORTAR_SE", dados.ImportarSe);
                commandSql.Parameters.AddWithValue("@CAUTELA", dados.Cautela);
                commandSql.Parameters.AddWithValue("@CLAREZA", dados.Clareza);
                commandSql.Parameters.AddWithValue("@COACHING", dados.Coaching);
                commandSql.Parameters.AddWithValue("@COMPROMETIMENTO", dados.Comprometimento);
                commandSql.Parameters.AddWithValue("@ENVOLVIMENTO_COMUNITARIO", dados.EnvolvimentoComunitario);
                commandSql.Parameters.AddWithValue("@COMPAIXAO", dados.Compaixao);
                commandSql.Parameters.AddWithValue("@SOLUCAO_DE_CONFLITOS", dados.SolucaoDeConflitos);
                commandSql.Parameters.AddWithValue("@CONFUSAO", dados.Confusao);
                commandSql.Parameters.AddWithValue("@MELHORIA_CONTINUA", dados.MelhoriaContinua);
                commandSql.Parameters.AddWithValue("@APRENDIZAGEM_CONTINUA", dados.AprendizagemContinua);
                commandSql.Parameters.AddWithValue("@CONTROLE", dados.Controle);
                commandSql.Parameters.AddWithValue("@COOPERACAO", dados.Cooperacao);
                commandSql.Parameters.AddWithValue("@REDUCAO_DE_CUSTOS", dados.ReducaoDeCustos);
                commandSql.Parameters.AddWithValue("@CORAGEM", dados.Coragem);
                commandSql.Parameters.AddWithValue("@CRIATIVIDADE", dados.Criatividade);
                commandSql.Parameters.AddWithValue("@COLABORACAO_ENTRE_GRUPOS", dados.ColaboracaoEntreGrupos);
                commandSql.Parameters.AddWithValue("@CURIOSIDADE", dados.Curiosidade);
                commandSql.Parameters.AddWithValue("@COLABORACAO_COM_O_CLIENTE", dados.ColaboracaoComCliente);
                commandSql.Parameters.AddWithValue("@SATISFACAO_DO_CLIENTE", dados.SatisfacaoDoCliente);
                commandSql.Parameters.AddWithValue("@CONFORTO_COM_INCERTEZAS", dados.ConfortoComIncertezas);
                commandSql.Parameters.AddWithValue("@EFICIENCIA", dados.Eficiencia);
                commandSql.Parameters.AddWithValue("@VALORIZANDO_A_DIVERSIDADE", dados.ValorizandoADiversidade);
                commandSql.Parameters.AddWithValue("@EXPANDIR_PODER", dados.ExpandirPoder);
                commandSql.Parameters.AddWithValue("@ENGAJAMENTO_DOS_FUNCIONARIOS", dados.EngajamentoDosFuncionarios);
                commandSql.Parameters.AddWithValue("@REALIZACAO_DO_FUNCIONARIO", dados.RealizacaoDoFuncionario);
                commandSql.Parameters.AddWithValue("@SAUDE_DO_FUNCIONARIO", dados.SaudeDoFuncionario);
                commandSql.Parameters.AddWithValue("@RECONHECIMENTO_DOS_FUNCIONARIOS", dados.ReconhecimentoDoFuncionario);
                commandSql.Parameters.AddWithValue("@EMPODERAR", dados.Empoderar);
                commandSql.Parameters.AddWithValue("@ENCORAJAMENTO", dados.Encorajamento);
                commandSql.Parameters.AddWithValue("@ENTUSIASMO", dados.Entusiasmo);
                commandSql.Parameters.AddWithValue("@EMPREENDEDORISMO", dados.Empreendedorismo);
                commandSql.Parameters.AddWithValue("@CONSCIENCIA_AMBIENTAL", dados.ConscienciaAmbiental);
                commandSql.Parameters.AddWithValue("@IGUALDADE", dados.Igualdade);
                commandSql.Parameters.AddWithValue("@EXCELENCIA", dados.Excelencia);
                commandSql.Parameters.AddWithValue("@EXPERIENCIA", dados.Experiencia);
                commandSql.Parameters.AddWithValue("@EXPLORACAO", dados.Exploracao);
                commandSql.Parameters.AddWithValue("@IMPARCIALIDADE", dados.Imparcialidade);
                commandSql.Parameters.AddWithValue("@ESTABILIDADE_FINANCEIRA", dados.EstabilidadeFinanceira);
                commandSql.Parameters.AddWithValue("@PERDAO", dados.Perdao);
                commandSql.Parameters.AddWithValue("@PREOCUPACAO_COM_FUTURAS_GERACOES", dados.PreocupacaoComFuturasGeracoes);
                commandSql.Parameters.AddWithValue("@LIDERANCA_GLOBAL", dados.LiderancaGlobal);
                commandSql.Parameters.AddWithValue("@ORIENTADO_PARA_OBJETIVOS", dados.OrientadoParaObjetivos);
                commandSql.Parameters.AddWithValue("@HIERARQUIA", dados.Hierarquia);
                commandSql.Parameters.AddWithValue("@PENSAMENTO_HOLISTICO", dados.PensamentoHolistico);
                commandSql.Parameters.AddWithValue("@HONESTIDADE", dados.Honestidade);
                commandSql.Parameters.AddWithValue("@DIREITOS_HUMANOS", dados.DireitosHumanos);
                commandSql.Parameters.AddWithValue("@HUMOR_ALEGRIA", dados.HumorAlegria);
                commandSql.Parameters.AddWithValue("@CAPACIDADE_DE_INCLUSAO", dados.CapacidadeDeInclusao);
                commandSql.Parameters.AddWithValue("@RETER_INFORMACOES", dados.ReterInformacoes);
                commandSql.Parameters.AddWithValue("@COMPARTILHAR_INFORMACOES", dados.CompartilharInformacoes);
                commandSql.Parameters.AddWithValue("@INICIATIVA", dados.Iniciativa);
                commandSql.Parameters.AddWithValue("@INOVACAO", dados.Inovacao);
                commandSql.Parameters.AddWithValue("@INTEGRIDADE", dados.Integridade);
                commandSql.Parameters.AddWithValue("@COMPETICAO_INTERNA", dados.CompeticaoInterna);
                commandSql.Parameters.AddWithValue("@INSEGURANCA_DO_EMPREGO", dados.InsegurancaDoEmprego);
                commandSql.Parameters.AddWithValue("@DESENVOLVIMENTO_DA_LIDERANCA", dados.DesenvolvimentoDaLideranca);
                commandSql.Parameters.AddWithValue("@LIDERANDO_PELO_EXEMPLO", dados.LiderandoPeloExemplo);
                commandSql.Parameters.AddWithValue("@ESCUTAR", dados.Escutar);
                commandSql.Parameters.AddWithValue("@TRABALHO_EXCESSIVO", dados.TrabalhoExcessivo);
                commandSql.Parameters.AddWithValue("@PERSPECTIVA_DE_LONGO_PRAZO", dados.PerspectivaDeLongoPrazo);
                commandSql.Parameters.AddWithValue("@FAZER_A_DIFERENCA", dados.FazerADiferenca);
                commandSql.Parameters.AddWithValue("@MANIPULACAO", dados.Manipulacao);
                commandSql.Parameters.AddWithValue("@FOCO_NA_MISSAO", dados.FocoNaMissao);
                commandSql.Parameters.AddWithValue("@COMUNICACAO_ABERTA", dados.ComunicaoAberta);
                commandSql.Parameters.AddWithValue("@ABERTURA", dados.Abertura);

                commandSql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (_databaseConnection.State == ConnectionState.Open)
                {
                    _databaseConnection.Dispose();
                }
            }

            return Task.FromResult(true);
        }

        private MySqlConnection ConectarBanco()
        {
            var Connection = _configuration.GetConnectionString("DefaultConnection");

            try

            {
                var connect = new MySqlConnection
                {
                    ConnectionString = Connection
                };

                connect.Open();

                return connect;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}