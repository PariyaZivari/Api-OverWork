using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class Units
    {
        public Units()
        {
            OverworkMaster = new HashSet<OverworkMaster>();
            ShiftPersonnel = new HashSet<ShiftPersonnel>();
            SpecialPersonnel = new HashSet<SpecialPersonnel>();
            UserUnits = new HashSet<UserUnits>();
        }

        public int UnitCode { get; set; }
        public string UnitName { get; set; }
        public int State { get; set; }

        public virtual RecordStates StateNavigation { get; set; }
        public virtual ICollection<OverworkMaster> OverworkMaster { get; set; }
        public virtual ICollection<ShiftPersonnel> ShiftPersonnel { get; set; }
        public virtual ICollection<SpecialPersonnel> SpecialPersonnel { get; set; }
        public virtual ICollection<UserUnits> UserUnits { get; set; }
    }
}
