using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookshelf.Models;

namespace MVCBookshelf.Controllers
{
    public class OrderIdSearchController : Controller
    {
        private pubsEntities db = new pubsEntities();

        // GET: OrderIdSearch
        public ActionResult Index()
        {
            IQueryable<titles> list1 = db.titles;
            IQueryable<sales> list = db.sales;

            var query = db.sales.SqlQuery("SELECT top (5) t.title_id, t.total_sales, S.order_date, A.au_fname, A.au_lname, A.phone, A.zip, A.au_id, t.title" +
                                           "FROM(SELECT title_id, max(ytd_sales) as total_sales, max(title) as title FROM titles GROUP BY title_id) T LEFT OUTER JOIN (SELECT title_id, max(ord_date) AS order_date" +
                                           "FROM sales GROUP BY title_id) S ON(T.title_id = S.title_id) LEFT OUTER JOIN (SELECT title_id, au_id FROM titleauthor) TA" +
                                           "ON(T.title_id = TA.title_id) LEFT OUTER JOIN (SELECT au_id, au_fname, au_lname, phone, zip FROM authors) A ON(TA.au_id = A.au_id)" +
                                           "WHERE total_sales is not null ORDER BY total_sales DESC");

            string storeName = Request.QueryString["stor_name"];
            string dateFrom = Request.QueryString["dateFrom"];
            string dateTo = Request.QueryString["dateTo"];

            if (storeName != null)
            {
                list = list.Where(m => m.stores.stor_name.StartsWith(storeName) );


                if (Request.QueryString["dateFrom"] != null && Request.QueryString["dateFrom"] != "")
                {
                    DateTime.TryParse(Request.QueryString["dateFrom"], out DateTime datefrom);
                    list = list.Where(m => m.ord_date >= datefrom);
                }

                if (Request.QueryString["dateTo"] != null && Request.QueryString["dateTo"] != "")
                {
                    DateTime.TryParse(Request.QueryString["dateTo"], out DateTime dateto);
                    list = list.Where(m => m.ord_date <= dateto);
                }

            }
            return View(list.ToList());
        }

        // GET: OrderIdSearch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderIdSearch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderIdSearch/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderIdSearch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderIdSearch/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderIdSearch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderIdSearch/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
