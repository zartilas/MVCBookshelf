using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class PublishersMetadata
    {
        [Display(Name = Lang.metadataPubName)]
        public string pub_name;

        [Display(Name = Lang.metadataState)]
        public string state;

        [Display(Name = Lang.metadataCity)]
        public string city;

        [Display(Name = Lang.metadataCountry)]
        public string country;
    }
}