using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MVCBookshelf.Models;
using PagedList;

namespace MVCBookshelf.Controllers
{
    public class AuthorsController : Controller
    {

        private pubsEntities db = new pubsEntities();

        // GET: Authors
        public ActionResult Index(string search, int? i)
        {
            ModelState.Clear();
            return View(db.authors.Where(x => x.au_fname.StartsWith(search)
                                         || x.au_lname.StartsWith(search)
                                         || x.phone.StartsWith(search)
                                         || x.address.StartsWith(search)
                                         || x.city.StartsWith(search)
                                         || x.state.StartsWith(search)
                                         || x.zip.StartsWith(search)
                                         || search == null).ToList().ToPagedList(i ?? 1, 5));
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
                ModelState.Clear();
                return RedirectToAction("Index");
            }

            return View(authors);
        }
        [HttpGet] // this action result returns the partial containing the modal
        public ActionResult Create(string id)
        {
            return View();
        }

        // GET
        [HttpGet] // this action result returns the partial containing the modal
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            authors author = db.authors.Find(id);
            if (author == null)
            {
                return HttpNotFound();
            }
            return View(author);
        }

        // POST
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "au_id, au_lname, au_fname, phone, address, city, state, zip, contract")] authors authors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(authors).State = EntityState.Modified;
                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Index");
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
            ModelState.Clear();
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
