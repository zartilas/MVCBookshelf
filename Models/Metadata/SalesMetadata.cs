using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class SalesMetadata
    {
        [Display(Name = Lang.metadataOrderNumber)]
        public string ord_num;

        [Display(Name = Lang.metadataOrderDate)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string ord_date;

        [Display(Name = Lang.metadataQuantity)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string qty;

        [Display(Name = Lang.metadataPayTerms)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string payterms;
    }
}