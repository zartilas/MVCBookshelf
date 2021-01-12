using System;

namespace MVCBookshelf.Models
{
    public class Sales
    {
        public int stor_id { get; set; }
        public String ord_num { get; set; }
        public long ord_date { get; set; }
        public int qty { get; set; }
        public String payterms { get; set; }
        public int title_id { get; set; }
    }
}