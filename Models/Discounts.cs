using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class Discounts
    {
        public String discounttype { get; set; }
        public int stor_id { get; set; }
        public int lowqty { get; set; }
        public int highqty { get; set; }
        public double discount { get; set; }
    }
}