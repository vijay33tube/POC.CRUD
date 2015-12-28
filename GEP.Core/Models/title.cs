using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class title
    {
        public title()
        {
            this.royscheds = new List<roysched>();
            this.sales = new List<sale>();
            this.titleauthors = new List<titleauthor>();
        }

        public string title_id { get; set; }
        public string title1 { get; set; }
        public string type { get; set; }
        public string pub_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> advance { get; set; }
        public Nullable<int> royalty { get; set; }
        public Nullable<int> ytd_sales { get; set; }
        public string notes { get; set; }
        public System.DateTime pubdate { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual publisher publisher { get; set; }
        public virtual ICollection<roysched> royscheds { get; set; }
        public virtual ICollection<sale> sales { get; set; }
        public virtual ICollection<titleauthor> titleauthors { get; set; }
    }
}
