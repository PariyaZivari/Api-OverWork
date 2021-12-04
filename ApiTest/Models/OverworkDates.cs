using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class OverworkDates
    {
        public OverworkDates()
        {
            OverworkMaster = new HashSet<OverworkMaster>();
        }

        public int Id { get; set; }
        public int PersonnelTypeId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public virtual PersonnelTypes PersonnelType { get; set; }
        public virtual ICollection<OverworkMaster> OverworkMaster { get; set; }
    }
}
