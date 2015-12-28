using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class store
    {
        public store()
        {
            this.discounts = new List<discount>();
            this.sales = new List<sale>();
        }

        public string stor_id { get; set; }
        public string stor_name { get; set; }
        public string stor_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual ICollection<discount> discounts { get; set; }
        public virtual ICollection<sale> sales { get; set; }
    }
}
