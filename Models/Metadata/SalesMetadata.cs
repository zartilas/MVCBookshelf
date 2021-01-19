using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class SalesMetadata
    {
        [Display(Name = Lang.metadataStor_name)]
        public string stor_name;

        [Display(Name = Lang.metadataTitle)]
        public string title;

        [Display(Name = Lang.metadataOrd_date)]
        public string ord_date;

        [Display(Name = Lang.metadataPayterms)]
        public string payterms;

        [Display(Name = Lang.metadataQty)]
        public string qty;
    }
}