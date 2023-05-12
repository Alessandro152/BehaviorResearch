using SearchForm.Models.Entites.Common;

namespace SearchForm.Models.Entites.Pesquisa
{
    public class ColagemDeOrganizacao : Resposta
    {
        public ColagemDeOrganizacao()
        {

        }

        public int FuncionarioId { get; private set; }
    }
}