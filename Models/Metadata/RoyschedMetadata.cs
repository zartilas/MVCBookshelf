using MVCBookshelf.Content.Values;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models.Metadata
{
    public class RoyschedMetadata
    {
        [Display(Name = Lang.metadataLorange)]
        public string lorange;

        [Display(Name = Lang.metadataRoyalty)]
        public string royalty;

        [Display(Name = Lang.metadataTitle)]
        public string title;

        [Display(Name = Lang.metadataHirange)]
        public string hirange;
    }
}