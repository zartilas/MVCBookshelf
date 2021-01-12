using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class Stores
    {
        public int stor_id { get; set; }
        public String stor_name{ get; set; }
        public String stor_address{ get; set; }
        public String city{ get; set; }
        public String state{ get; set; }
        public String zip{ get; set; }
    }
}