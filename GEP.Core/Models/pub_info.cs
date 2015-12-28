using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class pub_info
    {
        public string pub_id { get; set; }
        public byte[] logo { get; set; }
        public string pr_info { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual publisher publisher { get; set; }
    }
}
