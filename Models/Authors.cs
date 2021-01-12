using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class Authors
    {
        public String au_id { get; set; }
        public String au_lname { get; set; }
        public String au_fname { get; set; }
        public String phone { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zip { get; set; }
        public String contract { get; set; }
    }
}