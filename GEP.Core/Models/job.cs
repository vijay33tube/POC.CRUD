using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class job
    {
        public job()
        {
            this.employees = new List<employee>();
        }

        public short job_id { get; set; }
        public string job_desc { get; set; }
        public byte min_lvl { get; set; }
        public byte max_lvl { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual ICollection<employee> employees { get; set; }
    }
}
