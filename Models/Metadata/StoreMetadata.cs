using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class StoreMetadata
    {
        [Display(Name = Lang.metadataStoreName)]
        public string stor_name;

        [Display(Name = Lang.metadataStoreAddress)]
        public string stor_address;

        [Display(Name = Lang.metadataCity)]
        public string city;

        [Display(Name = Lang.metadataState)]
        public string state;

        [Display(Name = Lang.metadataZip)]
        public string zip;
    }
}