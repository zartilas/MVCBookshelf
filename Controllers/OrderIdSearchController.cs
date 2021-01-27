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
