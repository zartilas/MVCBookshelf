using System.Web.Mvc;

namespace MVCBookshelf.Controllers
{
    public class AdministrationController : Controller
    {
        // GET: Authors
        public ActionResult Authors()
        {
            return View();
        }
    }
}