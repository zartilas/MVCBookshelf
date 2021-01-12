using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class Jobs
    {
        public int job_id { get; set; }
        public String job_desc { get; set; }
        public int min_lvl { get; set; }
        public int max_lvl { get; set; }
    }
}