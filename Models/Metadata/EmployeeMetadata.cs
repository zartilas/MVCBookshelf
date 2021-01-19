using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCBookshelf.Content.Values;

namespace MVCBookshelf.Models.Metadata
{
    public class EmployeeMetadata
    {
        //private pubsEntities db = new pubsEntities();

        [Display(Name = Lang.metadataLastName)]
        public string lname;

        [Display(Name = Lang.metadataFirstName)]
        public string fname;

        [Display(Name = Lang.metadataMinit)]
        public string minit;

        [Display(Name = Lang.metadataPub_name)]
        public string pub_name;

        [Display(Name = Lang.metadataJob_lvl)]
        public string job_lvl;

        [Display(Name = Lang.metadataHire_date)]
        public string hire_date;

        [Display(Name = Lang.metadataJob_desc)]
        public string job_desc;
    }
}