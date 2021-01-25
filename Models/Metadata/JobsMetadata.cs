using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class JobsMetadata
    {
        [Display(Name = Lang.metadataJobDesc)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string job_desc;

        [Display(Name = Lang.metadataMinLvl)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string min_lvl;

        [Display(Name = Lang.metadataMaxLvl)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string max_lvl;
    }
}