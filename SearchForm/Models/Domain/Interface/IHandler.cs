namespace SearchForm.Models.Domain.Interface
{
    using SearchForm.Models.Domain.Common;
    using System.Threading.Tasks;

    public interface IHandler<in TMessage> where TMessage : Command
    {
        Task<bool> Handle(TMessage message);
    }
}