﻿namespace SearchForm.Models.Domain.Interface
{
    using SearchForm.Models.Entites.Common;
    using System.Threading.Tasks;

    public interface IRepository
    {
        Task<bool> SalvarPesquisa(PesquisaModel pesquisa);
    }
}
