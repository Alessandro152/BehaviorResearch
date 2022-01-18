namespace SearchForm.Models.AppServices
{
    using SearchForm.Models.QueryStack.Interface;
    using SearchForm.Models.Entites.Pesquisa;
    using System;
    using System.Threading.Tasks;
    using SearchForm.Models.Application.Interface;
    using SearchForm.Models.Entites.Common;
    using System.Text.RegularExpressions;
    using SearchForm.Models.Entites;

    public class AppServiceHandler : IPesquisaAppService
    {
        private const int VALOR_CAMPO_EXPECTATIVA_REALIDADE = 200;
        private int resultado;
        private readonly IRepository _repo;

        public AppServiceHandler(IRepository repo)
        {
            _repo = repo;
        }

        public Task<bool> SalvarPesquisa(BarrettValuesModel dados, PesquisaModel pesquisa)
        {
            return Task.FromResult(_repo.SalvarPesquisa(dados, pesquisa)).Result;
        }
    }
}
