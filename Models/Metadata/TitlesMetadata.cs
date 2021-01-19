using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MVCBookshelf.Content.Values;

namespace MVCBookshelf.Models.Metadata
{
    public class TitlesMetadata
    {
        [Display(Name = Lang.metadataTitle)]
        public string title;

        [Display(Name = Lang.metadataType)]
        public string type;

        [Display(Name = Lang.metadataPrice)]
        public string pricy;

        [Display(Name = Lang.metadataAdvance)]
        public string advance;

        [Display(Name = Lang.metadataRoyalty)]
        public string royalty;

        [Display(Name = Lang.metadataYtd_sales)]
        public string ytd_sales;

        [Display(Name = Lang.metadataNotes)]
        public string notes;

        [Display(Name = Lang.metadataPubdate)]
        public string pubdate;

        [Display(Name = Lang.metadataTitle_id)]
        public string title_id;
    }
}