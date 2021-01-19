using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class JobsMetadata
    {
        [Display(Name = Lang.metadataJobDesc)]
        [Required]
        public string job_desc;

        [Display(Name = Lang.metadataMinLvl)]
        [Required]
        public string min_lvl;

        [Display(Name = Lang.metadataMaxLvl)]
        [Required]
        public string max_lvl;
    }
}