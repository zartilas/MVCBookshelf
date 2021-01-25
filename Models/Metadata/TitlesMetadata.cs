using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class TitlesMetadata
    {
        [Display(Name = Lang.metadataTitleID)]
        public string title_id;

        [Display(Name = Lang.metadataTitle)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string title;

        [Display(Name = Lang.metadataType)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string type;

        [Display(Name = Lang.metadataPrice)]
        public string price;

        [Display(Name = Lang.metadataAdvance)]
        public string advance;

        [Display(Name = Lang.metadataRoyalty)]
        public string royalty;

        [Display(Name = Lang.metadataYtdSales)]
        public string ytd_sales;

        [Display(Name = Lang.metadataNotes)]
        public string notes;

        [Display(Name = Lang.metadataPubDate)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string pubdate;
    }
}