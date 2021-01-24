using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class AuthorsMetadata
    {
        [Display(Name = Lang.metadataAuthorId)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        [DataType(DataType.Text)]
        public string au_id;

        [Display(Name = Lang.metadataLastName)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        [StringLength(40, ErrorMessage = "Do not enter more than 40 characters")]
        [DataType(DataType.Text)]
        public string au_lname;

        [Display(Name = Lang.metadataFirstName)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [DataType(DataType.Text)]
        public string au_fname;

        [Display(Name = Lang.metadataPhone)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        [StringLength(12, ErrorMessage = "Do not enter more than 12 characters")]
        [RegularExpression("^[0-9- ]*$", ErrorMessage = "Please enter a valid phone number")]
        [DataType(DataType.PhoneNumber)]
        public string phone;

        [Display(Name = Lang.metadataAddress)]
        [StringLength(40, ErrorMessage = "Do not enter more than 40 characters")]
        [DataType(DataType.Text)]
        public string address;

        [Display(Name = Lang.metadataCity)]
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [DataType(DataType.Text)]
        public string city;

        [Display(Name = Lang.metadataState)]
        [StringLength(2, ErrorMessage = "Do not enter more than 2 characters")]
        [DataType(DataType.Text)]
        public string state;

        [Display(Name = Lang.metadataZip)]
        [StringLength(5, ErrorMessage = "Do not enter more than 5 characters")]
        [DataType(DataType.PostalCode)]
        public string zip;

        [Display(Name = Lang.metadataContract)]
        [Required(ErrorMessage = Lang.metadataRequiredField)]
        public string contract;
    }
}