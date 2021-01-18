using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models.Metadata
{
    public class DiscountsMetadata
    {
        private pubsEntities db = new pubsEntities();

        [Display(Name = "Last Name")]
        //[Required]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 50 characters!")]
        public string discounttype;
    }
}