using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class SalesMetadata
    {
        [Display(Name = Lang.metadataOrderNumber)]
        [DataType(DataType.Text)]
        public string ord_num;

        [Display(Name = Lang.metadataOrderDate)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public string ord_date;

        [Display(Name = Lang.metadataStoreId)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter a valid number")]
        public string stor_id;

        [Display(Name = Lang.metadataTitleId)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string title_id;

        [Display(Name = Lang.metadataQuantity)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter a valid number")]
        public string qty;

        [Display(Name = Lang.metadataPayTerms)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string payterms;
    }
}