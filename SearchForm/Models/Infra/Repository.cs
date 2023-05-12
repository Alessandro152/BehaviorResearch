using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace SearchForm.Models.Infra
{
    public class Repository : IRepository
    {
        private readonly IConfiguration _configuration;
        private MySqlConnection _databaseConnection;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
            _databaseConnection = ConectarBanco();
        }

        public Task<bool> AddFuncionario(FuncionarioCommand message)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SalvarPesquisa()
        {
            return default;
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