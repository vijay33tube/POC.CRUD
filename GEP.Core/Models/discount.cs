using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class discount
    {
        public string discounttype { get; set; }
        public string stor_id { get; set; }
        public Nullable<short> lowqty { get; set; }
        public Nullable<short> highqty { get; set; }
        public decimal discount1 { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual store store { get; set; }
    }
}
