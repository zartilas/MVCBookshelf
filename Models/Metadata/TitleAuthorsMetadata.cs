using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class TitleAuthorsMetadata
    {
        [Display(Name = Lang.metadataTitle)]
        public string title;

        [Display(Name = Lang.metadataLastName)]
        public string au_lname;

        [Display(Name = Lang.metadataAu_ord)]
        public string au_ord;

        [Display(Name = Lang.metadataRoyaltyper)]
        public string royaltyper;
    }
}