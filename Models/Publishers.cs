using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class Publishers
    {
        public int pub_id { get; set; }
        public String pub_name { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String country { get; set; }
    }
}