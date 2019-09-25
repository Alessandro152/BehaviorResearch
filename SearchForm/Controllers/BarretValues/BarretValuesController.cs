
using SearchForm.Models.ViewModels.BarretValues;
using System.Web.Mvc;

namespace SearchForm.Controllers.BarretValues
{
    public class BarrettValuesController : Controller
    {
        // GET: BarretValues
        public ActionResult BarrettValues()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FinishView(BarretValuesViewModel valores)
        {
            return RedirectToAction("Finish", "LastPage");
        }
    }
}