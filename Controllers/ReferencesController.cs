using MVCBookshelf.Models;
using System.Web.Mvc;

namespace MVCBookshelf.Controllers
{
    public class ReferencesController : Controller
    {
        private pubsEntities db = new pubsEntities();
        public ActionResult Index()
        {
            return View(ContactDetails());  
        }

        public ActionResult ContactDetails()
        {

            string dateTo = Request.QueryString["dateTo"];
            string dateFrom = Request.QueryString["dateFrom"];
            string numSales = Request.QueryString["numOfTopSales"];

            var query = db.authors.SqlQuery("SELECT top (" + numSales + ") t.title_id, t.total_sales, S.order_date, A.au_fname, A.au_lname, A.phone, A.zip, A.au_id, t.title" +
                                            "FROM(SELECT title_id, sum(qty) as total_sales, max(title) as title FROM titles GROUP BY title_id) T LEFT OUTER JOIN (SELECT title_id, max(ord_date) AS order_date" +
                                            "FROM sales GROUP BY title_id) S ON(T.title_id = S.title_id) LEFT OUTER JOIN (SELECT title_id, au_id FROM titleauthor) TA" +
                                            "ON(T.title_id = TA.title_id) LEFT OUTER JOIN (SELECT au_id, au_fname, au_lname, phone, zip FROM authors) A ON(TA.au_id = A.au_id)" +
                                            "WHERE total_sales is not null AND order_date BETWEEN '" + dateFrom + "' and '" + dateTo + "' ORDER BY total_sales DESC");


            return View(query);
        }

        public ActionResult OrderIdSearch()
        {
            return View();
        }
    }
}