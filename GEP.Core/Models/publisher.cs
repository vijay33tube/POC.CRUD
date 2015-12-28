using System;
using System.Collections.Generic;

namespace GEP.Core.Models
{
    public partial class publisher
    {
        public publisher()
        {
            this.employees = new List<employee>();
            this.titles = new List<title>();
        }

        public string pub_id { get; set; }
        public string pub_name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public Nullable<System.DateTime> CreateDts { get; set; }
        public Nullable<System.DateTime> UpdateDts { get; set; }
        public string CreateSource { get; set; }
        public string UpdateSource { get; set; }
        public byte[] TimeStamp { get; set; }
        public virtual ICollection<employee> employees { get; set; }
        public virtual pub_info pub_info { get; set; }
        public virtual ICollection<title> titles { get; set; }
    }
}
