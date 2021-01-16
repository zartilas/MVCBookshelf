using System.Linq;
using System.Web.Mvc;
using MVCBookshelf.Models;

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