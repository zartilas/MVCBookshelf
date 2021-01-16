using System.Linq;
using System.Web.Mvc;
using MVCBookshelf.Models;

namespace MVCBookshelf.Controllers
{
    public class AdministrationController : Controller
    {
        // GET: Authors
        public ActionResult Authors(string id)
        {
            AuthorsContext authorsContext = new AuthorsContext();
            authors authors = authorsContext.Authors.Single(auth => auth.au_id == id);

            return View(authors);
        }
    }
}