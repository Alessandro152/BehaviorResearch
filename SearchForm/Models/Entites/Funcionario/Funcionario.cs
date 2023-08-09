using SearchForm.Models.Entites.Common;

namespace SearchForm.Models.Entites.Funcionario
{
    public class Funcionario : Entidade
    {
        public Funcionario()
        {
                
        }

        public string Nome { get; }
        public string Departamento { get; }
        public string Cargo { get; }
    }
}