using MySql.Data.MySqlClient;
using SearchForm.Models.ViewModels;
using SearchForm.Models.ViewModels.CaracteristicasDominantes;
using SearchForm.Models.ViewModels.ColagemDeOrganizacao;
using SearchForm.Models.ViewModels.CriteriosDeSucesso;
using SearchForm.Models.ViewModels.EnfaseEstrategica;
using SearchForm.Models.ViewModels.GestaoDeFuncionarios;
using SearchForm.Models.ViewModels.LiderancaOrganizacional;
using System;
using System.Data;


namespace SearchForm.Infra.Reprositories
{
    public class Repository
    {
        private MySqlConnection connect;
        public MySqlConnection DatabaseConnection { get; private set; }

        internal void SalvarDadosPessoa(personViewModel pessoa)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO PESSOA(NOME, DEPARTAMENTO, CARGO) VALUES(@NOME, @DEPARTAMENTO, @CARGO)";
                Comm.Parameters.AddWithValue("@NOME", pessoa.Nome);
                Comm.Parameters.AddWithValue("@DEPARTAMENTO", pessoa.Departamento);
                Comm.Parameters.AddWithValue("@CARGO", pessoa.Cargo);
                Comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(DatabaseConnection.State == ConnectionState.Open)
                {
                    DatabaseConnection.Close();
                }
            }
        }

        internal void SalvarCaracteristicasDominantes(CaracteristicasDominantesViewModel caracteristicas)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO CARACTERISTICASDOMINANTES(CD_A_EXPECT, CD_A_REAL, CD_B_EXPECT, CD_B_REAL, CD_C_EXPECT, CD_C_REAL, CD_D_EXPECT, CD_D_REAL) VALUES(@CD_A_EXPECT, @CD_A_REAL, @CD_B_EXPECT, @CD_B_REAL, @CD_C_EXPECT, @CD_C_REAL, @CD_D_EXPECT, @CD_D_REAL)";
                Comm.Parameters.AddWithValue("@CD_A_EXPECT", caracteristicas.CD_LetraAExpect);
                Comm.Parameters.AddWithValue("@CD_A_REAL", caracteristicas.CD_LetraAReal);
                Comm.Parameters.AddWithValue("@CD_B_EXPECT", caracteristicas.CD_LetraBExpect);
                Comm.Parameters.AddWithValue("@CD_B_REAL", caracteristicas.CD_LetraBReal);
                Comm.Parameters.AddWithValue("@CD_C_EXPECT", caracteristicas.CD_LetraCExpect);
                Comm.Parameters.AddWithValue("@CD_C_REAL", caracteristicas.CD_LetraCReal);
                Comm.Parameters.AddWithValue("@CD_D_EXPECT", caracteristicas.CD_LetraDExpect);
                Comm.Parameters.AddWithValue("@CD_D_REAL", caracteristicas.CD_LetraDReal);
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
                    DatabaseConnection.Close();
                }
            }
        }

        internal void SalvarLiderancaOrganizacional(LiderancaOrganizacionalViewModel lideranca)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO LIDERANCAORGANIZACIONAL(LO_A_EXPECT, LO_A_REAL, LO_B_EXPECT, LO_B_REAL, LO_C_EXPECT, LO_C_REAL, LO_D_EXPECT, LO_D_REAL) VALUES(@LO_A_EXPECT, @LO_A_REAL, @LO_B_EXPECT, @LO_B_REAL, @LO_C_EXPECT, @LO_C_REAL, @LO_D_EXPECT, @LO_D_REAL)";
                Comm.Parameters.AddWithValue("@LO_A_EXPECT", lideranca.LO_LetraAExpect);
                Comm.Parameters.AddWithValue("@LO_A_REAL", lideranca.LO_LetraAReal);
                Comm.Parameters.AddWithValue("@LO_B_EXPECT", lideranca.LO_LetraBExpect);
                Comm.Parameters.AddWithValue("@LO_B_REAL", lideranca.LO_LetraBReal);
                Comm.Parameters.AddWithValue("@LO_C_EXPECT", lideranca.LO_LetraCExpect);
                Comm.Parameters.AddWithValue("@LO_C_REAL", lideranca.LO_LetraCReal);
                Comm.Parameters.AddWithValue("@LO_D_EXPECT", lideranca.LO_LetraDExpect);
                Comm.Parameters.AddWithValue("@LO_D_REAL", lideranca.LO_LetraDReal);
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
                    DatabaseConnection.Close();
                }
            }
        }

        internal void SalvarGestaoDeFuncionarios(GestaoDeFuncionariosViewModel gestao)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO GESTAODEFUNCIONARIOS(GF_A_EXPECT, GF_A_REAL, GF_B_EXPECT, GF_B_REAL, GF_C_EXPECT, GF_C_REAL, GF_D_EXPECT, GF_D_REAL) VALUES(@GF_A_EXPECT, @GF_A_REAL, @GF_B_EXPECT, @GF_B_REAL, @GF_C_EXPECT, @GF_C_REAL, @GF_D_EXPECT, @GF_D_REAL)";
                Comm.Parameters.AddWithValue("@GF_A_EXPECT", gestao.GF_LetraAExpect);
                Comm.Parameters.AddWithValue("@GF_A_REAL", gestao.GF_LetraAReal);
                Comm.Parameters.AddWithValue("@GF_B_EXPECT", gestao.GF_LetraBExpect);
                Comm.Parameters.AddWithValue("@GF_B_REAL", gestao.GF_LetraBReal);
                Comm.Parameters.AddWithValue("@GF_C_EXPECT", gestao.GF_LetraCExpect);
                Comm.Parameters.AddWithValue("@GF_C_REAL", gestao.GF_LetraCReal);
                Comm.Parameters.AddWithValue("@GF_D_EXPECT", gestao.GF_LetraDExpect);
                Comm.Parameters.AddWithValue("@GF_D_REAL", gestao.GF_LetraDReal);
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
                    DatabaseConnection.Close();
                }
            }
        }

        internal void SalvarColagemDeOrganizacao(ColagemDeOrganizacaoViewModel colagem)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO COLAGEMDEORGANIZACAO(CO_A_EXPECT, CO_A_REAL, CO_B_EXPECT, CO_B_REAL, CO_C_EXPECT, CO_C_REAL, CO_D_EXPECT, CO_D_REAL) VALUES(@CO_A_EXPECT, @CO_A_REAL, @CO_B_EXPECT, @CO_B_REAL, @CO_C_EXPECT, @CO_C_REAL, @CO_D_EXPECT, @CO_D_REAL)";
                Comm.Parameters.AddWithValue("@CO_A_EXPECT", colagem.CO_LetraAExpect);
                Comm.Parameters.AddWithValue("@CO_A_REAL", colagem.CO_LetraAReal);
                Comm.Parameters.AddWithValue("@CO_B_EXPECT", colagem.CO_LetraBExpect);
                Comm.Parameters.AddWithValue("@CO_B_REAL", colagem.CO_LetraBReal);
                Comm.Parameters.AddWithValue("@CO_C_EXPECT", colagem.CO_LetraCExpect);
                Comm.Parameters.AddWithValue("@CO_C_REAL", colagem.CO_LetraCReal);
                Comm.Parameters.AddWithValue("@CO_D_EXPECT", colagem.CO_LetraDExpect);
                Comm.Parameters.AddWithValue("@CO_D_REAL", colagem.CO_LetraDReal);
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
                    DatabaseConnection.Close();
                }
            }
        }

        internal void SalvarEnfaseEstrategica(EnfaseEstrategicaViewModel enfase)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO ENFASEESTRATEGICA(EE_A_EXPECT, EE_A_REAL, EE_B_EXPECT, EE_B_REAL, EE_C_EXPECT, EE_C_REAL, EE_D_EXPECT, EE_D_REAL) VALUES(@EE_A_EXPECT, @EE_A_REAL, @EE_B_EXPECT, @EE_B_REAL, @EE_C_EXPECT, @EE_C_REAL, @EE_D_EXPECT, @EE_D_REAL)";
                Comm.Parameters.AddWithValue("@EE_A_EXPECT", enfase.EE_LetraAExpect);
                Comm.Parameters.AddWithValue("@EE_A_REAL", enfase.EE_LetraAReal);
                Comm.Parameters.AddWithValue("@EE_B_EXPECT", enfase.EE_LetraBExpect);
                Comm.Parameters.AddWithValue("@EE_B_REAL", enfase.EE_LetraBReal);
                Comm.Parameters.AddWithValue("@EE_C_EXPECT", enfase.EE_LetraCExpect);
                Comm.Parameters.AddWithValue("@EE_C_REAL", enfase.EE_LetraCReal);
                Comm.Parameters.AddWithValue("@EE_D_EXPECT", enfase.EE_LetraDExpect);
                Comm.Parameters.AddWithValue("@EE_D_REAL", enfase.EE_LetraDReal);
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
                    DatabaseConnection.Close();
                }
            }
        }

        internal void SalvarCriteriosDeSucesso(CriteriosDeSucessoViewModel criterios)
        {
            try
            {
                MySqlCommand Comm;
                DatabaseConnection = conexaoBanco();

                Comm = DatabaseConnection.CreateCommand();

                Comm.CommandText = "USE FORMULARIO";
                Comm.ExecuteNonQuery();

                Comm.CommandText = "INSERT INTO CRITERIOSDESUCESSO(CS_A_EXPECT, CS_A_REAL, CS_B_EXPECT, CS_B_REAL, CS_C_EXPECT, CS_C_REAL, CS_D_EXPECT, CS_D_REAL) VALUES(@CS_A_EXPECT, @CS_A_REAL, @CS_B_EXPECT, @CS_B_REAL, @CS_C_EXPECT, @CS_C_REAL, @CS_D_EXPECT, @CS_D_REAL)";
                Comm.Parameters.AddWithValue("@CS_A_EXPECT", criterios.CS_LetraAExpect);
                Comm.Parameters.AddWithValue("@CS_A_REAL", criterios.CS_LetraAReal);
                Comm.Parameters.AddWithValue("@CS_B_EXPECT", criterios.CS_LetraBExpect);
                Comm.Parameters.AddWithValue("@CS_B_REAL", criterios.CS_LetraBReal);
                Comm.Parameters.AddWithValue("@CS_C_EXPECT", criterios.CS_LetraCExpect);
                Comm.Parameters.AddWithValue("@CS_C_REAL", criterios.CS_LetraCReal);
                Comm.Parameters.AddWithValue("@CS_D_EXPECT", criterios.CS_LetraDExpect);
                Comm.Parameters.AddWithValue("@CS_D_REAL", criterios.CS_LetraDReal);
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
                    DatabaseConnection.Close();
                }
            }
        }

        private MySqlConnection conexaoBanco()
        {
            string Connection = "server=localhost;uid=root;pwd=1234;";

            try

            {
                connect = new MySqlConnection();
                connect.ConnectionString = Connection;
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