using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class Titles
    {
        public String title_id { get; set; }
        public String title { get; set; }
        public String type { get; set; }
        public int pub_id { get; set; }
        public String price { get; set; }
        public String advance { get; set; }
        public int royalty { get; set; }
        public int ytd_sales { get; set; }
        public String notes { get; set; }
        public long pub_date{ get; set; }
    }
}