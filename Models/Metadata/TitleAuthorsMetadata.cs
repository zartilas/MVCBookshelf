using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class TitleAuthorsMetadata
    {
        [Display(Name = Lang.metadataAuthorId)]
        public string au_id;

        [Display(Name = Lang.metadataTitleId)]
        public string title_id;

        [Display(Name = Lang.metadataAuthorOrder)]
        public string au_ord;

        [Display(Name = Lang.metadataRoyaltyper)]
        public string royaltyper;
    }
}