using MVCBookshelf.Models;
using PagedList;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVCBookshelf.Controllers
{
    public class SalesController : Controller
    {
        private pubsEntities db = new pubsEntities();

        // GET: Sales
        public ActionResult Index(string search, int? i)
        {
            var sales = db.sales.Include(s => s.stores).Include(s => s.titles);
            return View(db.sales.Where(x => x.ord_date.ToString().StartsWith(search)
                                            || x.qty.ToString().StartsWith(search)
                                            || x.payterms.StartsWith(search)
                                            || x.stores.stor_name.StartsWith(search)
                                            || x.titles.title.StartsWith(search)
                                            || search == null).ToList().ToPagedList(i ?? 1, 5));
        }

        // GET: Sales/Create
        public ActionResult Create()
        {
            List<string> list = new List<string>();
            list.Add("Net 30");
            list.Add("Net 60");
            list.Add("ON Invoice");
            ViewBag.Payterms = new SelectList(list);
            return View();
        }

        // POST: Sales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "stor_id,ord_num,ord_date,qty,payterms,title_id")] sales sales)
        {
            if (ModelState.IsValid)
            {
                db.sales.Add(sales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.stor_id = new SelectList(db.stores, "stor_id", "stor_name", sales.stor_id);
            ViewBag.title_id = new SelectList(db.titles, "title_id", "title", sales.title_id);
            return View(sales);
        }

        // GET: Sales/Edit/5
        public ActionResult Edit(string store_id, string title_id, string ord_num)
        {
            if (store_id == null || title_id == null || ord_num == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sales sales = db.sales.Find(store_id, ord_num, title_id);
            if (sales == null)
            {
                return HttpNotFound();
            }
            List<string> list = new List<string>();
            ViewBag.payterms = new SelectList(db.sales, "payterms", "", sales.payterms);
            ViewBag.stor_id = new SelectList(db.stores, "stor_id", "stor_name", sales.stor_id);
            ViewBag.title_id = new SelectList(db.titles, "title_id", "title", sales.title_id);
            return View(sales);
        }

        // POST: Sales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "stor_id,ord_num,ord_date,qty,payterms,title_id")] sales sales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.stor_id = new SelectList(db.stores, "stor_id", "stor_name", sales.stor_id);
            ViewBag.title_id = new SelectList(db.titles, "title_id", "title", sales.title_id);
            return View(sales);
        }

        // GET: Sales/Delete/5
        public ActionResult Delete(string store_id, string title_id, string ord_num)
        {
            if (store_id == null || title_id == null || ord_num == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sales sales = db.sales.Find(store_id, ord_num, title_id);
            if (sales == null)
            {
                return HttpNotFound();
            }
            return View(sales);
        }

        // POST: Sales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            sales sales = db.sales.Find(id);
            db.sales.Remove(sales);
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