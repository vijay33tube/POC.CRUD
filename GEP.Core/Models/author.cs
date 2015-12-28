using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class author
    {
        public author()
        {
            this.titleauthors = new List<titleauthor>();
        }

        public string au_id { get; set; }
        public string au_lname { get; set; }
        public string au_fname { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public bool contract { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual ICollection<titleauthor> titleauthors { get; set; }
    }
}
