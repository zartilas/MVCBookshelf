using MVCBookshelf.Models.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models
{
    [MetadataType(typeof(AuthorsMetadata))]
    public partial class authors
    {
    }


    [MetadataType(typeof(DiscountsMetadata))]
    public partial class discounts
    {
    }
}