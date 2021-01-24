using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class DiscountsMetadata
    {
        [Display(Name = Lang.metadataDiscountType)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        [StringLength(40, ErrorMessage = "Do not enter more than 40 characters")]
        [DataType(DataType.Text)]
        public string discounttype;

        [Display(Name = Lang.metadataStoreId)]
        [StringLength(4, ErrorMessage = "Do not enter more than 4 characters")]
        [DataType(DataType.Text)]
        public string stor_id;

        [Display(Name = Lang.metadataLowqty)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter a valid number")]
        public string lowqty;

        [Display(Name = Lang.metadataHighqty)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter a valid number")]
        public string highqty;

        [Display(Name = Lang.metadataDiscount)]
        [RegularExpression("^\\d+(\\.\\d{1,2})?$", ErrorMessage = "Please enter a valid number of length 4")]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string discount;
    }
}