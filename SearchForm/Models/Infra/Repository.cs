using MySql.Data.MySqlClient;
using SearchForm.Models.QueryStack.Interface;
using SearchForm.Models.QueryStack.ViewModels.Pesquisa;
using System;
using System.Data;


namespace SearchForm.Models.Infra
{
    public class Repository : IRepository
    {
        private MySqlConnection connect;
        public MySqlConnection DatabaseConnection { get; private set; }

        public void SalvarRespostas(DadosPesquisaViewModel dados)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO PESSOA (NOME, DEPARTAMENTO, CARGO) VALUES(@NOME, @DEPARTAMENTO, @CARGO)";
                Comm.Parameters.AddWithValue("@NOME", dados.Funcionario.Nome);
                Comm.Parameters.AddWithValue("@DEPARTAMENTO", dados.Funcionario.Departamento);
                Comm.Parameters.AddWithValue("@CARGO", dados.Funcionario.Cargo);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO CARACTERISTICASDOMINANTES (CD_A_EXPECT, CD_A_REAL, CD_B_EXPECT, CD_B_REAL, CD_C_EXPECT, CD_C_REAL, CD_D_EXPECT, CD_D_REAL) VALUES(@CD_A_EXPECT, @CD_A_REAL, @CD_B_EXPECT, @CD_B_REAL, @CD_C_EXPECT, @CD_C_REAL, @CD_D_EXPECT, @CD_D_REAL)";
                Comm.Parameters.AddWithValue("@CD_A_EXPECT", dados.CaracteristicasDominantes.CD_LetraAExpect);
                Comm.Parameters.AddWithValue("@CD_A_REAL", dados.CaracteristicasDominantes.CD_LetraAReal);
                Comm.Parameters.AddWithValue("@CD_B_EXPECT", dados.CaracteristicasDominantes.CD_LetraBExpect);
                Comm.Parameters.AddWithValue("@CD_B_REAL", dados.CaracteristicasDominantes.CD_LetraBReal);
                Comm.Parameters.AddWithValue("@CD_C_EXPECT", dados.CaracteristicasDominantes.CD_LetraCExpect);
                Comm.Parameters.AddWithValue("@CD_C_REAL", dados.CaracteristicasDominantes.CD_LetraCReal);
                Comm.Parameters.AddWithValue("@CD_D_EXPECT", dados.CaracteristicasDominantes.CD_LetraDExpect);
                Comm.Parameters.AddWithValue("@CD_D_REAL", dados.CaracteristicasDominantes.CD_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO LIDERANCAORGANIZACIONAL(LO_A_EXPECT, LO_A_REAL, LO_B_EXPECT, LO_B_REAL, LO_C_EXPECT, LO_C_REAL, LO_D_EXPECT, LO_D_REAL) VALUES(@LO_A_EXPECT, @LO_A_REAL, @LO_B_EXPECT, @LO_B_REAL, @LO_C_EXPECT, @LO_C_REAL, @LO_D_EXPECT, @LO_D_REAL)";
                Comm.Parameters.AddWithValue("@LO_A_EXPECT", dados.LiderancaOrganizacional.LO_LetraAExpect);
                Comm.Parameters.AddWithValue("@LO_A_REAL", dados.LiderancaOrganizacional.LO_LetraAReal);
                Comm.Parameters.AddWithValue("@LO_B_EXPECT", dados.LiderancaOrganizacional.LO_LetraBExpect);
                Comm.Parameters.AddWithValue("@LO_B_REAL", dados.LiderancaOrganizacional.LO_LetraBReal);
                Comm.Parameters.AddWithValue("@LO_C_EXPECT", dados.LiderancaOrganizacional.LO_LetraCExpect);
                Comm.Parameters.AddWithValue("@LO_C_REAL", dados.LiderancaOrganizacional.LO_LetraCReal);
                Comm.Parameters.AddWithValue("@LO_D_EXPECT", dados.LiderancaOrganizacional.LO_LetraDExpect);
                Comm.Parameters.AddWithValue("@LO_D_REAL", dados.LiderancaOrganizacional.LO_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO GESTAODEFUNCIONARIOS(GF_A_EXPECT, GF_A_REAL, GF_B_EXPECT, GF_B_REAL, GF_C_EXPECT, GF_C_REAL, GF_D_EXPECT, GF_D_REAL) VALUES(@GF_A_EXPECT, @GF_A_REAL, @GF_B_EXPECT, @GF_B_REAL, @GF_C_EXPECT, @GF_C_REAL, @GF_D_EXPECT, @GF_D_REAL)";
                Comm.Parameters.AddWithValue("@GF_A_EXPECT", dados.GestaoDeFuncionarios.GF_LetraAExpect);
                Comm.Parameters.AddWithValue("@GF_A_REAL", dados.GestaoDeFuncionarios.GF_LetraAReal);
                Comm.Parameters.AddWithValue("@GF_B_EXPECT", dados.GestaoDeFuncionarios.GF_LetraBExpect);
                Comm.Parameters.AddWithValue("@GF_B_REAL", dados.GestaoDeFuncionarios.GF_LetraBReal);
                Comm.Parameters.AddWithValue("@GF_C_EXPECT", dados.GestaoDeFuncionarios.GF_LetraCExpect);
                Comm.Parameters.AddWithValue("@GF_C_REAL", dados.GestaoDeFuncionarios.GF_LetraCReal);
                Comm.Parameters.AddWithValue("@GF_D_EXPECT", dados.GestaoDeFuncionarios.GF_LetraDExpect);
                Comm.Parameters.AddWithValue("@GF_D_REAL", dados.GestaoDeFuncionarios.GF_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO COLAGEMDEORGANIZACAO(CO_A_EXPECT, CO_A_REAL, CO_B_EXPECT, CO_B_REAL, CO_C_EXPECT, CO_C_REAL, CO_D_EXPECT, CO_D_REAL) VALUES(@CO_A_EXPECT, @CO_A_REAL, @CO_B_EXPECT, @CO_B_REAL, @CO_C_EXPECT, @CO_C_REAL, @CO_D_EXPECT, @CO_D_REAL)";
                Comm.Parameters.AddWithValue("@CO_A_EXPECT", dados.ColagemDeOrganizacao.CO_LetraAExpect);
                Comm.Parameters.AddWithValue("@CO_A_REAL", dados.ColagemDeOrganizacao.CO_LetraAReal);
                Comm.Parameters.AddWithValue("@CO_B_EXPECT", dados.ColagemDeOrganizacao.CO_LetraBExpect);
                Comm.Parameters.AddWithValue("@CO_B_REAL", dados.ColagemDeOrganizacao.CO_LetraBReal);
                Comm.Parameters.AddWithValue("@CO_C_EXPECT", dados.ColagemDeOrganizacao.CO_LetraCExpect);
                Comm.Parameters.AddWithValue("@CO_C_REAL", dados.ColagemDeOrganizacao.CO_LetraCReal);
                Comm.Parameters.AddWithValue("@CO_D_EXPECT", dados.ColagemDeOrganizacao.CO_LetraDExpect);
                Comm.Parameters.AddWithValue("@CO_D_REAL", dados.ColagemDeOrganizacao.CO_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO ENFASEESTRATEGICA(EE_A_EXPECT, EE_A_REAL, EE_B_EXPECT, EE_B_REAL, EE_C_EXPECT, EE_C_REAL, EE_D_EXPECT, EE_D_REAL) VALUES(@EE_A_EXPECT, @EE_A_REAL, @EE_B_EXPECT, @EE_B_REAL, @EE_C_EXPECT, @EE_C_REAL, @EE_D_EXPECT, @EE_D_REAL)";
                Comm.Parameters.AddWithValue("@EE_A_EXPECT", dados.EnfaseEstrategica.EE_LetraAExpect);
                Comm.Parameters.AddWithValue("@EE_A_REAL", dados.EnfaseEstrategica.EE_LetraAReal);
                Comm.Parameters.AddWithValue("@EE_B_EXPECT", dados.EnfaseEstrategica.EE_LetraBExpect);
                Comm.Parameters.AddWithValue("@EE_B_REAL", dados.EnfaseEstrategica.EE_LetraBReal);
                Comm.Parameters.AddWithValue("@EE_C_EXPECT", dados.EnfaseEstrategica.EE_LetraCExpect);
                Comm.Parameters.AddWithValue("@EE_C_REAL", dados.EnfaseEstrategica.EE_LetraCReal);
                Comm.Parameters.AddWithValue("@EE_D_EXPECT", dados.EnfaseEstrategica.EE_LetraDExpect);
                Comm.Parameters.AddWithValue("@EE_D_REAL", dados.EnfaseEstrategica.EE_LetraDReal);
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO CRITERIOSDESUCESSO(CS_A_EXPECT, CS_A_REAL, CS_B_EXPECT, CS_B_REAL, CS_C_EXPECT, CS_C_REAL, CS_D_EXPECT, CS_D_REAL) VALUES(@CS_A_EXPECT, @CS_A_REAL, @CS_B_EXPECT, @CS_B_REAL, @CS_C_EXPECT, @CS_C_REAL, @CS_D_EXPECT, @CS_D_REAL)";
                Comm.Parameters.AddWithValue("@CS_A_EXPECT", dados.CriteriosDeSucesso.CS_LetraAExpect);
                Comm.Parameters.AddWithValue("@CS_A_REAL", dados.CriteriosDeSucesso.CS_LetraAReal);
                Comm.Parameters.AddWithValue("@CS_B_EXPECT", dados.CriteriosDeSucesso.CS_LetraBExpect);
                Comm.Parameters.AddWithValue("@CS_B_REAL", dados.CriteriosDeSucesso.CS_LetraBReal);
                Comm.Parameters.AddWithValue("@CS_C_EXPECT", dados.CriteriosDeSucesso.CS_LetraCExpect);
                Comm.Parameters.AddWithValue("@CS_C_REAL", dados.CriteriosDeSucesso.CS_LetraCReal);
                Comm.Parameters.AddWithValue("@CS_D_EXPECT", dados.CriteriosDeSucesso.CS_LetraDExpect);
                Comm.Parameters.AddWithValue("@CS_D_REAL", dados.CriteriosDeSucesso.CS_LetraDReal);
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
        }

        public void SalvarBarrettValues(BarrettValuesViewModel valores)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO BARRETTVALUES (SENSO_DE_DONO, ATINGIR_OBJETIVOS, ADAPTABILIDADE, EQUILIBRIO, SER_O_MELHOR, CULPAR, IMAGEM_DA_MARCA, BUROCRACIA, IMPORTAR_SE, CAUTELA," +
                    "CLAREZA, COACHING, COMPROMETIMENTO, ENVOLVIMENTO_COMUNITARIO, COMPAIXAO, SOLUCAO_DE_CONFLITOS, CONFUSAO, MELHORIA_CONTINUA, APRENDIZAGEM_CONTINUA, CONTROLE, " +
                    "COOPERACAO, REDUCAO_DE_CUSTOS, CORAGEM, CRIATIVIDADE, COLABORACAO_ENTRE_GRUPOS, CURIOSIDADE, COLABORACAO_COM_O_CLIENTE, SATISFACAO_DO_CLIENTE, CONFORTO_COM_INCERTEZAS, EFICIENCIA, " +
                    "VALORIZANDO_A_DIVERSIDADE, EXPANDIR_PODER, ENGAJAMENTO_DOS_FUNCIONARIOS, REALIZACAO_DO_FUNCIONARIO, SAUDE_DO_FUNCIONARIO, RECONHECIMENTO_DOS_FUNCIONARIOS, EMPODERAR, ENCORAJAMENTO, ENTUSIASMO, EMPREENDEDORISMO, " +
                    "CONSCIENCIA_AMBIENTAL, IGUALDADE, EXCELENCIA, EXPERIENCIA, EXPLORACAO, IMPARCIALIDADE, ESTABILIDADE_FINANCEIRA, PERDAO, PREOCUPACAO_COM_FUTURAS_GERACOES, " +
                    "LIDERANCA_GLOBAL, ORIENTADO_PARA_OBJETIVOS, HIERARQUIA, PENSAMENTO_HOLISTICO, HONESTIDADE, DIREITOS_HUMANOS, HUMOR_ALEGRIA, CAPACIDADE_DE_INCLUSAO, RETER_INFORMACOES, COMPARTILHAR_INFORMACOES, " +
                    "INICIATIVA, INOVACAO, INTEGRIDADE, COMPETICAO_INTERNA, INSEGURANCA_DO_EMPREGO, DESENVOLVIMENTO_DA_LIDERANCA, LIDERANDO_PELO_EXEMPLO, ESCUTAR, TRABALHO_EXCESSIVO, PERSPECTIVA_DE_LONGO_PRAZO, " +
                    "FAZER_A_DIFERENCA, MANIPULACAO, FOCO_NA_MISSAO, COMUNICACAO_ABERTA, ABERTURA) " +
                    "VALUES(@SENSO_DE_DONO, @ATINGIR_OBJETIVOS, @ADAPTABILIDADE, @EQUILIBRIO, @SER_O_MELHOR, @CULPAR, @IMAGEM_DA_MARCA, @BUROCRACIA, @IMPORTAR_SE, @CAUTELA," +
                    "@CLAREZA, @COACHING, @COMPROMETIMENTO, @ENVOLVIMENTO_COMUNITARIO, @COMPAIXAO, @SOLUCAO_DE_CONFLITOS, @CONFUSAO, @MELHORIA_CONTINUA, @APRENDIZAGEM_CONTINUA, @CONTROLE, " +
                    "@COOPERACAO, @REDUCAO_DE_CUSTOS, @CORAGEM, @CRIATIVIDADE, @COLABORACAO_ENTRE_GRUPOS, @CURIOSIDADE, @COLABORACAO_COM_O_CLIENTE, @SATISFACAO_DO_CLIENTE, @CONFORTO_COM_INCERTEZAS, @EFICIENCIA, " +
                    "@VALORIZANDO_A_DIVERSIDADE, @EXPANDIR_PODER, @ENGAJAMENTO_DOS_FUNCIONARIOS, @REALIZACAO_DO_FUNCIONARIO, @SAUDE_DO_FUNCIONARIO, @RECONHECIMENTO_DOS_FUNCIONARIOS, @EMPODERAR, @ENCORAJAMENTO, @ENTUSIASMO, @EMPREENDEDORISMO, " +
                    "@CONSCIENCIA_AMBIENTAL, @IGUALDADE, @EXCELENCIA, @EXPERIENCIA, @EXPLORACAO, @IMPARCIALIDADE, @ESTABILIDADE_FINANCEIRA, @PERDAO, @PREOCUPACAO_COM_FUTURAS_GERACOES, " +
                    "@LIDERANCA_GLOBAL, @ORIENTADO_PARA_OBJETIVOS, @HIERARQUIA, @PENSAMENTO_HOLISTICO, @HONESTIDADE, @DIREITOS_HUMANOS, @HUMOR_ALEGRIA, @CAPACIDADE_DE_INCLUSAO, @RETER_INFORMACOES, @COMPARTILHAR_INFORMACOES, " +
                    "@INICIATIVA, @INOVACAO, @INTEGRIDADE, @COMPETICAO_INTERNA, @INSEGURANCA_DO_EMPREGO, @DESENVOLVIMENTO_DA_LIDERANCA, @LIDERANDO_PELO_EXEMPLO, @ESCUTAR, @TRABALHO_EXCESSIVO, @PERSPECTIVA_DE_LONGO_PRAZO, " +
                    "@FAZER_A_DIFERENCA, @MANIPULACAO, @FOCO_NA_MISSAO, @COMUNICACAO_ABERTA, @ABERTURA)";
                Comm.Parameters.AddWithValue("@SENSO_DE_DONO", valores.SensoDeDono);
                Comm.Parameters.AddWithValue("@ATINGIR_OBJETIVOS", valores.AtingirObjetivos);
                Comm.Parameters.AddWithValue("@ADAPTABILIDADE", valores.Adaptabilidade);
                Comm.Parameters.AddWithValue("@EQUILIBRIO", valores.Equilibrio);
                Comm.Parameters.AddWithValue("@SER_O_MELHOR", valores.SerOMelhor);
                Comm.Parameters.AddWithValue("@CULPAR", valores.Culpar);
                Comm.Parameters.AddWithValue("@IMAGEM_DA_MARCA", valores.ImagemDaMarca);
                Comm.Parameters.AddWithValue("@BUROCRACIA", valores.Burocracia);
                Comm.Parameters.AddWithValue("@IMPORTAR_SE", valores.ImportarSe);
                Comm.Parameters.AddWithValue("@CAUTELA", valores.Cautela);
                Comm.Parameters.AddWithValue("@CLAREZA", valores.Clareza);
                Comm.Parameters.AddWithValue("@COACHING", valores.Coaching);
                Comm.Parameters.AddWithValue("@COMPROMETIMENTO", valores.Comprometimento);
                Comm.Parameters.AddWithValue("@ENVOLVIMENTO_COMUNITARIO", valores.EnvolvimentoComunitario);
                Comm.Parameters.AddWithValue("@COMPAIXAO", valores.Compaixao);
                Comm.Parameters.AddWithValue("@SOLUCAO_DE_CONFLITOS", valores.SolucaoDeConflitos);
                Comm.Parameters.AddWithValue("@CONFUSAO", valores.Confusao);
                Comm.Parameters.AddWithValue("@MELHORIA_CONTINUA", valores.MelhoriaContinua);
                Comm.Parameters.AddWithValue("@APRENDIZAGEM_CONTINUA", valores.AprendizagemContinua);
                Comm.Parameters.AddWithValue("@CONTROLE", valores.Controle);
                Comm.Parameters.AddWithValue("@COOPERACAO", valores.Cooperacao);
                Comm.Parameters.AddWithValue("@REDUCAO_DE_CUSTOS", valores.ReducaoDeCustos);
                Comm.Parameters.AddWithValue("@CORAGEM", valores.Coragem);
                Comm.Parameters.AddWithValue("@CRIATIVIDADE", valores.Criatividade);
                Comm.Parameters.AddWithValue("@COLABORACAO_ENTRE_GRUPOS", valores.ColaboracaoEntreGrupos);
                Comm.Parameters.AddWithValue("@CURIOSIDADE", valores.Curiosidade);
                Comm.Parameters.AddWithValue("@COLABORACAO_COM_O_CLIENTE", valores.ColaboracaoComCliente);
                Comm.Parameters.AddWithValue("@SATISFACAO_DO_CLIENTE", valores.SatisfacaoDoCliente);
                Comm.Parameters.AddWithValue("@CONFORTO_COM_INCERTEZAS", valores.ConfortoComIncertezas);
                Comm.Parameters.AddWithValue("@EFICIENCIA", valores.Eficiencia);
                Comm.Parameters.AddWithValue("@VALORIZANDO_A_DIVERSIDADE", valores.ValorizandoADiversidade);
                Comm.Parameters.AddWithValue("@EXPANDIR_PODER", valores.ExpandirPoder);
                Comm.Parameters.AddWithValue("@ENGAJAMENTO_DOS_FUNCIONARIOS", valores.EngajamentoDosFuncionarios);
                Comm.Parameters.AddWithValue("@REALIZACAO_DO_FUNCIONARIO", valores.RealizacaoDoFuncionario);
                Comm.Parameters.AddWithValue("@SAUDE_DO_FUNCIONARIO", valores.SaudeDoFuncionario);
                Comm.Parameters.AddWithValue("@RECONHECIMENTO_DOS_FUNCIONARIOS", valores.ReconhecimentoDoFuncionario);
                Comm.Parameters.AddWithValue("@EMPODERAR", valores.Empoderar);
                Comm.Parameters.AddWithValue("@ENCORAJAMENTO", valores.Encorajamento);
                Comm.Parameters.AddWithValue("@ENTUSIASMO", valores.Entusiasmo);
                Comm.Parameters.AddWithValue("@EMPREENDEDORISMO", valores.Empreendedorismo);
                Comm.Parameters.AddWithValue("@CONSCIENCIA_AMBIENTAL", valores.ConscienciaAmbiental);
                Comm.Parameters.AddWithValue("@IGUALDADE", valores.Igualdade);
                Comm.Parameters.AddWithValue("@EXCELENCIA", valores.Excelencia);
                Comm.Parameters.AddWithValue("@EXPERIENCIA", valores.Experiencia);
                Comm.Parameters.AddWithValue("@EXPLORACAO", valores.Exploracao);
                Comm.Parameters.AddWithValue("@IMPARCIALIDADE", valores.Imparcialidade);
                Comm.Parameters.AddWithValue("@ESTABILIDADE_FINANCEIRA", valores.EstabilidadeFinanceira);
                Comm.Parameters.AddWithValue("@PERDAO", valores.Perdao);
                Comm.Parameters.AddWithValue("@PREOCUPACAO_COM_FUTURAS_GERACOES", valores.PreocupacaoComFuturasGeracoes);
                Comm.Parameters.AddWithValue("@LIDERANCA_GLOBAL", valores.LiderancaGlobal);
                Comm.Parameters.AddWithValue("@ORIENTADO_PARA_OBJETIVOS", valores.OrientadoParaObjetivos);
                Comm.Parameters.AddWithValue("@HIERARQUIA", valores.Hierarquia);
                Comm.Parameters.AddWithValue("@PENSAMENTO_HOLISTICO", valores.PensamentoHolistico);
                Comm.Parameters.AddWithValue("@HONESTIDADE", valores.Honestidade);
                Comm.Parameters.AddWithValue("@DIREITOS_HUMANOS", valores.DireitosHumanos);
                Comm.Parameters.AddWithValue("@HUMOR_ALEGRIA", valores.HumorAlegria);
                Comm.Parameters.AddWithValue("@CAPACIDADE_DE_INCLUSAO", valores.CapacidadeDeInclusao);
                Comm.Parameters.AddWithValue("@RETER_INFORMACOES", valores.ReterInformacoes);
                Comm.Parameters.AddWithValue("@COMPARTILHAR_INFORMACOES", valores.CompartilharInformacoes);
                Comm.Parameters.AddWithValue("@INICIATIVA", valores.Iniciativa);
                Comm.Parameters.AddWithValue("@INOVACAO", valores.Inovacao);
                Comm.Parameters.AddWithValue("@INTEGRIDADE", valores.Integridade);
                Comm.Parameters.AddWithValue("@COMPETICAO_INTERNA", valores.CompeticaoInterna);
                Comm.Parameters.AddWithValue("@INSEGURANCA_DO_EMPREGO", valores.InsegurancaDoEmprego);
                Comm.Parameters.AddWithValue("@DESENVOLVIMENTO_DA_LIDERANCA", valores.DesenvolvimentoDaLideranca);
                Comm.Parameters.AddWithValue("@LIDERANDO_PELO_EXEMPLO", valores.LiderandoPeloExemplo);
                Comm.Parameters.AddWithValue("@ESCUTAR", valores.Escutar);
                Comm.Parameters.AddWithValue("@TRABALHO_EXCESSIVO", valores.TrabalhoExcessivo);
                Comm.Parameters.AddWithValue("@PERSPECTIVA_DE_LONGO_PRAZO", valores.PerspectivaDeLongoPrazo);
                Comm.Parameters.AddWithValue("@FAZER_A_DIFERENCA", valores.FazerADiferenca);
                Comm.Parameters.AddWithValue("@MANIPULACAO", valores.Manipulacao);
                Comm.Parameters.AddWithValue("@FOCO_NA_MISSAO", valores.FocoNaMissao);
                Comm.Parameters.AddWithValue("@COMUNICACAO_ABERTA", valores.ComunicaoAberta);
                Comm.Parameters.AddWithValue("@ABERTURA", valores.Abertura);

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
        }

        private MySqlConnection conexaoBanco()
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