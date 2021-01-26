using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class RoyschedMetadata
    {
        [Display(Name = Lang.metadataLorange)]
        public string lorange;

        [Display(Name = Lang.metadataRoyalty)]
        public string royalty;

        [Display(Name = Lang.metadataHirange)]
        public string hirange;

        [Display(Name = Lang.metadataTitleId)]
        public string title_id;
    }
}