using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MVCBookshelf.Models;

namespace MVCBookshelf.Controllers
{
    public class AuthorsController : Controller
    {
        private pubsEntities db = new pubsEntities();

        // GET: Authors
        public ActionResult Index()
        {
            return View(db.authors.ToList());
        }

        // POST: Authors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "au_id,au_lname,au_fname,phone,address,city,state,zip,contract")] authors authors)
        {
            if (ModelState.IsValid)
            {
                db.authors.Add(authors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(authors);
        }
        [HttpGet] // this action result returns the partial containing the modal
        public ActionResult CreateAuthor(string id)
        {
            var viewModel = new authors();
            viewModel.au_id = id;
            return PartialView("_CreateAuthor", viewModel);
        }

        // GET
        [HttpGet] // this action result returns the partial containing the modal
        public ActionResult EditAuthor(string author_id)
        {
            /*List<authors> listAuthors = db.authors.ToList();
            ViewBag.AuthorsList = new SelectList(listAuthors, "au_id", "au_fname");

            AuthorViewModel model = new AuthorViewModel();



            authors auth = db.authors.SingleOrDefault(x => x.au_id == author_id);*/
            /* model.EmployeeId = emp.EmployeeId;
             model.DepartmentId = emp.DepartmentId;
             model.Name = emp.Name;
             model.Address = emp.Address;*/

            if (author_id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            authors author = db.authors.Find(author_id);
            if (author == null)
            {
                return HttpNotFound();
            }
            return PartialView("_EditAuthor", author);
        }

        // POST
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAuthor([Bind(Include = "au_id, au_lname, au_fname, phone, address, city, state, zip, contract")] authors authors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(authors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("/Authors/Index");
            }
            return View(authors);
        }

        // GET: Authors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            authors authors = db.authors.Find(id);
            if (authors == null)
            {
                return HttpNotFound();
            }
            return View(authors);
        }

        // POST: Authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            authors authors = db.authors.Find(id);
            db.authors.Remove(authors);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
