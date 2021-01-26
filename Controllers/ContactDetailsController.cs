using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookshelf.Models;

namespace MVCBookshelf.Controllers
{
    public class ContactDetailsController : Controller
    {

        private pubsEntities db = new pubsEntities();

        // GET: ContactDetails
        public ActionResult Index()
        {
            IQueryable<authors> list1 = db.authors;

            IQueryable<sales> list = db.sales;

            string numberOfSales = Request.QueryString["userInput"];

            if (numberOfSales != null && numberOfSales != "")
            {

                List<string> titleIdList;

                }
            foreach (var item in (List<string>)list.Where(m => m.stor_id != null))
            {
                if (item.Equals(item))//δαμε θελει σκεψη
                {
                    Console.WriteLine(item);
                }



            }
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

           return View(list.ToList());
        }


        // GET: ContactDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactDetails/Create
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

        // GET: ContactDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactDetails/Edit/5
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

        // GET: ContactDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactDetails/Delete/5
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
