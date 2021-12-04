using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class OverworkStates
    {
        public OverworkStates()
        {
            OverworkMaster = new HashSet<OverworkMaster>();
        }

        public int Id { get; set; }
        public string OverworkStateName { get; set; }

        public virtual ICollection<OverworkMaster> OverworkMaster { get; set; }
    }
}
