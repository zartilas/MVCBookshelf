using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class EmployeeMetadata
    {
        [Display(Name = Lang.metadataEmployeeId)]
        [StringLength(9, ErrorMessage = "Do not enter more than 9 characters")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string emp_id;

        [Display(Name = Lang.metadataFirstName)]
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string fname;

        [Display(Name = Lang.metadataMinit)]
        [StringLength(1, ErrorMessage = "Do not enter more than 1 characters")]
        [DataType(DataType.Text)]
        public string minit;

        [Display(Name = Lang.metadataLastName)]
        [StringLength(30, ErrorMessage = "Do not enter more than 30 characters")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string lname;

        [Display(Name = Lang.metadataJobId)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter a valid number")]
        public string job_id;

        [Display(Name = Lang.metadataJobLvl)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter a valid number")]
        public string job_lvl;

        [Display(Name = Lang.metadataPubId)]
        [DataType(DataType.Text)]
        public string pub_id;

        [Display(Name = Lang.metadataHireDate)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string hire_date;
    }
}