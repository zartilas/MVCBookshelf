using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class DiscountsMetadata
    {
        //private pubsEntities db = new pubsEntities();

        [Display(Name = Lang.metadataDiscountType)]
        [Required]
        public string discounttype;

        [Display(Name = Lang.metadataLowqty)]
        public string lowqty;

        [Display(Name = Lang.metadataHighqty)]
        public string highqty;

        [Display(Name = Lang.metadataDiscount)]
        [Required]
        public string discount;
    }
}