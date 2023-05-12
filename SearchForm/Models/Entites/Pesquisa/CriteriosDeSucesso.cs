
using SearchForm.Models.Entites.Common;

namespace SearchForm.Models.Entites.Pesquisa
{
    public class CriteriosDeSucesso : Resposta
    {
        public CriteriosDeSucesso()
        {

        }

        public int FuncionarioId { get; private set; }
    }
}