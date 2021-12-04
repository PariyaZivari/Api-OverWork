using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class OverworkMaster
    {
        public OverworkMaster()
        {
            OverworkContract = new HashSet<OverworkContract>();
            OverworkOfficial = new HashSet<OverworkOfficial>();
        }

        public int Id { get; set; }
        public int OverworkDateId { get; set; }
        public int UnitCode { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public int State { get; set; }

        public virtual OverworkDates OverworkDate { get; set; }
        public virtual OverworkStates StateNavigation { get; set; }
        public virtual Units UnitCodeNavigation { get; set; }
        public virtual ICollection<OverworkContract> OverworkContract { get; set; }
        public virtual ICollection<OverworkOfficial> OverworkOfficial { get; set; }
    }
}
