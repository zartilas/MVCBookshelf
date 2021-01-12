using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class Employee
    {
        public int emp_id { get; set; }
        public String fname { get; set; }
        public char minit { get; set; }
        public String lname { get; set; }
        public int job_id { get; set; }
        public int pub_id { get; set; }
        public long hire_date { get; set; }
    }
}