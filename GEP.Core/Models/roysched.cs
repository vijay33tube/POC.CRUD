using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class roysched
    {
        public string title_id { get; set; }
        public Nullable<int> lorange { get; set; }
        public Nullable<int> hirange { get; set; }
        public Nullable<int> royalty { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual title title { get; set; }
    }
}
