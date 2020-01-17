using SearchForm.Controllers.Principal;
using SearchForm.Models.ViewModels;
using SearchForm.Models.ViewModels.BarrettValues;

namespace SearchForm.Controllers.Interface
{
    public interface IRepository
    {
        void SalvarRespostas(GlobalViewModel dados);
        void SalvarBarrettValues(BarrettValuesViewModel barrettValues);
    }
}
