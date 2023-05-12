using SearchForm.Models.Entites.Common;

namespace SearchForm.Models.Entites.Pesquisa
{
    public class GestaoDeFuncionarios : Resposta
    {
        public GestaoDeFuncionarios()
        {

        }

        public int FuncionarioId { get; private set; }
    }
}