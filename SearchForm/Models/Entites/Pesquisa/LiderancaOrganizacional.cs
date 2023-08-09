using SearchForm.Models.Entites.Common;

namespace SearchForm.Models.Entites.Pesquisa
{
    public class LiderancaOrganizacional : Resposta
    {
        public LiderancaOrganizacional()
        {

        }

        public int FuncionarioId { get; private set; }
    }
}