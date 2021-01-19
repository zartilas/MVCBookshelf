using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCBookshelf.Content.Values;

namespace MVCBookshelf.Models.Metadata
{
    public class DiscountsMetadata
    {
        //private pubsEntities db = new pubsEntities();

        [Display(Name = Lang.metadataLowqty)]
        public string lowqty;

        [Display(Name = Lang.metadataHighqty)]
        public string highqty;

        [Display(Name = Lang.metadataStor_name)]
        public string stor_name;
    }
}