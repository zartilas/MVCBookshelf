using System;

namespace MVCBookshelf.Models.ViewModels
{
    public class ModelViewTopSales
    {
        public string title_id { get; set; }
        public string title_name { get; set; }
        public int total_sales { get; set; }
        public DateTime order_date { get; set; }
        public string au_fname { get; set; }
        public string au_lname { get; set; }
        public string phone { get; set; }
    }
}