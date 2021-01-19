using MVCBookshelf.Content.Values;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models.Metadata
{
    public class PublishersMetadata
    {
        [Display(Name = Lang.metadataPub_name)]
        public string pub_name;

        [Display(Name = Lang.metadataState)]
        public string state;

        [Display(Name = Lang.metadataCity)]
        public string city;

        [Display(Name = Lang.metadataCountry)]
        public string country;

        [Display(Name = Lang.metadataPr_info)]
        public string pr_info;
    }
}