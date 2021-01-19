using MVCBookshelf.Content.Values;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBookshelf.Models.Metadata
{
    public class JobsMetadata
    {
        [Display(Name = Lang.metadataJob_desc)]
        public string job_desc;

                [Display(Name = Lang.metadataMin_lvl)]
        public string min_lvl;

        [Display(Name = Lang.metadataMax_lvl)]
        public string max_lvl;
    }
}