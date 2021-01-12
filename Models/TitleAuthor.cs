using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    public class TitleAuthor
    {
        public String au_id { get; set; }
        public String title_id { get; set; }
        public int au_ord { get; set; }
        public int royaltyper { get; set; }
    }
}