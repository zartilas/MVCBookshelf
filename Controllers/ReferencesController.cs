using MVCBookshelf.Models;
using MVCBookshelf.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCBookshelf.Controllers
{
    public class ReferencesController : Controller
    {
        private pubsEntities db = new pubsEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactDetails()
        {
            string topNum = Request.QueryString["TopNum"];
            string dateTo = Request.QueryString["DateTo"];
            string dateFrom = Request.QueryString["DateFrom"];

            string query = null;
            if (topNum != null && topNum != "")
            {
                int topNumConverted = int.Parse(topNum);
                if (topNumConverted > 0)
                    query = "SELECT top (cast('" + topNumConverted + "' as int)) ";
                else
                    query = "SELECT ";

                query += "t.title_id, t.title_name, S.total_sales, S.order_date, A.au_fname, A.au_lname, A.phone, A.zip, A.au_id " +
                         "FROM(SELECT title_id, sum(qty) as total_sales, max(ord_date) AS order_date, MIN(ord_date) AS mindate " +
                         "FROM sales " +
                         "GROUP BY title_id) S " +
                         "LEFT OUTER JOIN " +
                         "(SELECT title_id, max(title) as title_name " +
                         "FROM titles " +
                         "GROUP BY title_id ) T " +
                         "ON(T.title_id = S.title_id) " +
                         "LEFT OUTER JOIN " +
                         "(SELECT title_id, au_id " +
                         "FROM titleauthor) TA " +
                         "ON(T.title_id = TA.title_id) " +
                         "LEFT OUTER JOIN " +
                         "(SELECT au_id, au_fname, au_lname, phone, zip " +
                         "FROM authors) A " +
                         "ON(TA.au_id = A.au_id) " +
                         "WHERE total_sales is not null ";
            }
            else
            {
                return View();
            }
            if (dateFrom != null && dateFrom != "" && (dateTo == null || dateTo == ""))
            {
                DateTime.TryParse(dateFrom, out DateTime dateFromConverted);
                query += "AND order_date >= '" + dateFromConverted + "' ";
            }
            else if ((dateFrom == null || dateFrom == "") && dateTo != null && dateTo != "")
            {
                DateTime.TryParse(dateTo, out DateTime dateToConverted);
                query += "AND order_date <= '" + dateToConverted + "' ";
            }
            else if (dateFrom != null && dateFrom != "" && dateTo != null && dateTo != "")
            {
                DateTime.TryParse(dateFrom, out DateTime dateFromConverted);
                DateTime.TryParse(dateTo, out DateTime dateToConverted);
                query += "AND order_date BETWEEN '" + dateFromConverted + "' AND '" + dateToConverted + "' ";
            }

            if (query == null)
            {
                query = "SELECT au_id FROM authors WHERE au_id='0'";
                IEnumerable<ModelViewTopSales> myAreaList = db.Database.SqlQuery<ModelViewTopSales>(query);
                return View(myAreaList.ToList());
            }
            else
            {
                query += "ORDER BY total_sales DESC";
                IEnumerable<ModelViewTopSales> myAreaList = db.Database.SqlQuery<ModelViewTopSales>(query);
                return View(myAreaList.ToList());
            }
        }

        public ActionResult OrderID()
        {
            string dateFrom = Request.QueryString["DateFrom"];
            string dateTo = Request.QueryString["DateTo"];
            string storeNameFrom = Request.QueryString["StoreNameFrom"];
            string storeNameTo = Request.QueryString["StoreNameTo"];

            string query = null;
            if (dateFrom != null && dateFrom != "")
            {
                query = "SELECT S.ord_num, T.title, ST.stor_name, ord_date, s.title_id " +
                        "From( " +
                        "SELECT title_id, ord_date, ord_num, stor_id " +
                        "FROM sales " +
                        "group by title_id, ord_num, ord_date, stor_id) S " +
                        "LEFT OUTER JOIN " +
                        "(SELECT stor_name, stor_id " +
                        "From stores " +
                        "Group by stor_id, stor_name) ST " +
                        "ON(ST.stor_id = S.stor_id) " +
                        "LEFT OUTER JOIN " +
                        "(SELECT title, title_id " +
                        "From titles " +
                        "group by title_id, title) T " +
                        "ON(T.title_id = S.title_id) " +
                        "WHERE ";
            }
            else
            {
                return View();
            }

            if (dateTo == null || dateTo == "")
            {
                DateTime.TryParse(dateFrom, out DateTime dateFromConverted);
                query += "S.ord_date >= '" + dateFromConverted + "'";
            }
            else if (dateFrom != null && dateFrom != "" && dateTo != null && dateTo != "")
            {
                DateTime.TryParse(dateFrom, out DateTime dateFromConverted);
                DateTime.TryParse(dateTo, out DateTime dateToConverted);
                query += "S.ord_date BETWEEN '" + dateFromConverted + "' AND '" + dateToConverted + "'";
            }

            if (storeNameFrom != null && storeNameFrom != "" && (storeNameTo == null || storeNameTo == ""))
            {
                query += " AND stor_name LIKE '" + storeNameFrom + "%' ";
            }
            else if ((storeNameFrom != null && storeNameFrom != "") && (storeNameTo != null && storeNameTo != ""))
            {
                query += " AND stor_name LIKE '["+storeNameFrom+"-"+storeNameTo+"]%'";
            }

            if (query == null)
            {
                query = "SELECT stor_id FROM stores WHERE stor_id='0'";
                IEnumerable<ModelViewOrderID> myAreaList = db.Database.SqlQuery<ModelViewOrderID>(query);
                return View(myAreaList.ToList());
            }
            else
            {
                query += " ORDER BY ord_date DESC";
                IEnumerable<ModelViewOrderID> myAreaList = db.Database.SqlQuery<ModelViewOrderID>(query);
                return View(myAreaList.ToList());
            }
        }
    }
}