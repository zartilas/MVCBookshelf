using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class PubInfoMetadata
    {
        [Display(Name = "Logo")]
        public string logo;

        [Display(Name = "Publisher Info")]
        public string pr_info;
    }
}