using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class SalesMetadata
    {
        [Display(Name = Lang.metadataOrderNumber)]
        public string ord_num;

        [Display(Name = Lang.metadataOrderDate)]
        [Required]
        public string ord_date;

        [Display(Name = Lang.metadataQuantity)]
        [Required]
        public string qty;

        [Display(Name = Lang.metadataPayTerms)]
        [Required]
        public string payterms;
    }
}