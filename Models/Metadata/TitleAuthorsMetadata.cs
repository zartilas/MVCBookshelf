using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class TitleAuthorsMetadata
    {
        [Display(Name = Lang.metadataAuthorOrder)]
        public string au_ord;

        [Display(Name = Lang.metadataRoyaltyper)]
        public string royaltyper;
    }
}