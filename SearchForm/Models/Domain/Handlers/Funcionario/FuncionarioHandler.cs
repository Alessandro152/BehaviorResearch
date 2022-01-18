namespace SearchForm.Models.Domain.Handlers.Funcionario
{
    using SearchForm.Models.Domain.Commands.Funcionario;
    using SearchForm.Models.Domain.Interface;
    using System;
    using System.Threading.Tasks;

    public class FuncionarioHandler : IHandler<FuncionarioCommand>
    {
        private readonly IRepository _repository;

        public FuncionarioHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(FuncionarioCommand message)
        {
            if (message == null)
            {
                return false;
            }

            try
            {
                var result = await _repository.AddFuncionario(message).ConfigureAwait(false);

                if (!result) return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }
    }
}