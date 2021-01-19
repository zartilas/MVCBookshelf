using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class AuthorsMetadata
    {
        private pubsEntities db = new pubsEntities();
        //[Required]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 50 characters!")]

        [Display(Name = Lang.metadataLastName)]
        [Required]
        public string au_lname;

        [Display(Name = Lang.metadataFirstName)]
        [Required]
        public string au_fname;

        [Display(Name = Lang.metadataPhone)]
        [Required]
        public string phone;

        [Display(Name = Lang.metadataAddress)]
        public string address;

        [Display(Name = Lang.metadataCity)]
        public string city;

        [Display(Name = Lang.metadataState)]
        public string state;

        [Display(Name = Lang.metadataZip)]
        public string zip;

        [Display(Name = Lang.metadataContract)]
        [Required]
        public string contract;
    }
}