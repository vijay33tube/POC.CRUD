using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class titleauthor
    {
        public string au_id { get; set; }
        public string title_id { get; set; }
        public Nullable<byte> au_ord { get; set; }
        public Nullable<int> royaltyper { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual author author { get; set; }
        public virtual title title { get; set; }
    }
}
