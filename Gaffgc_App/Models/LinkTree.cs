using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using Gaffgc_App.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gaffgc_App
{
    public class LinkTree : DbContext
    {
        [Key]
        public int id { get; set; }
        public virtual IList<DNA> DnaStore { get; set; }

        public LinkTree()
        {
            DnaStore = new List<DNA>();
        }
    }
}
