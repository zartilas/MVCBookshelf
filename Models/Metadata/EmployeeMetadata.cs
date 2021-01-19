using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    /*    [MetadataType(typeof(EmployeeMetadata))]
        public partial class employee
        {
        }*/

    public class EmployeeMetadata
    {
        private pubsEntities db = new pubsEntities();

        [Display(Name = Lang.metadataFirstName)]
        [Required]
        public string fname;

        [Display(Name = Lang.metadataMinit)]
        public string minit;

        [Display(Name = Lang.metadataLastName)]
        [Required]
        public string lname;

        [Display(Name = Lang.metadataJobLvl)]
        public string job_lvl;

        [Display(Name = Lang.metadataHireDate)]
        [Required]
        public string hire_date;
    }
}