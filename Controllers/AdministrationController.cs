 using System.Web.Mvc;
using MVCBookshelf.Models;

namespace MVCBookshelf.Controllers
{
    public class AdministrationController : Controller
    {
        // GET: Authors
        public ActionResult Authors()
        {
            Authors authors = new Authors()
            {
                
            };
            return View(authors);
        }
    }
}