using System.Web.Mvc;

namespace MVCBookshelf.Controllers
{
    public class ReferencesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult result(int numTop, string test)
        {
            return View();
        }
    }
}