using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    [MetadataType(typeof(PubInfoMetadata))]
    public partial class PubInfo
    {
    }

    public class PubInfoMetadata
    {
        [Display(Name = "Logo")]
        public string logo;

        [Display(Name = "Publisher Info")]
        public string pr_info;
    }
}