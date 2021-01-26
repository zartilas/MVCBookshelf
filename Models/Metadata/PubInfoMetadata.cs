using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class PubInfoMetadata
    {
        [Display(Name = "Logo")]
        public string logo;

        [Display(Name = "PUBLISHER INFO")]
        public string pr_info;
    }
}