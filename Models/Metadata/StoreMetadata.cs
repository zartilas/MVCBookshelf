using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBookshelf.Content.Values;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models.Metadata
{
    public class StoreMetadata
    {
        [Display(Name = Lang.metadataStor_name)]
        public string stor_name;

        [Display(Name = Lang.metadataCity)]
        public string city;

        [Display(Name = Lang.metadataState)]
        public string state;

        [Display(Name = Lang.metadataZip)]
        public string zip;

        [Display(Name = Lang.metadataStor_address)]
        public string stor_address;
    }
}