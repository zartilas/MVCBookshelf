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

            string storeName = Request.QueryString["stor_name"];

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
                list = list.Where(m => m.ord_num == m.ord_num);
                list = list.Where(m => m.title_id == m.titles.title_id);

            }
            return View();
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
