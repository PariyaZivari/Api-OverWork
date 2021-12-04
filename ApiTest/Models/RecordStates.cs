using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class RecordStates
    {
        public RecordStates()
        {
            Managers = new HashSet<Managers>();
            OverworkBasicData = new HashSet<OverworkBasicData>();
            ShiftPersonnel = new HashSet<ShiftPersonnel>();
            SoftwareVersion = new HashSet<SoftwareVersion>();
            SpecialPersonnel = new HashSet<SpecialPersonnel>();
            Units = new HashSet<Units>();
            UserUnits = new HashSet<UserUnits>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string RecordStateName { get; set; }

        public virtual ICollection<Managers> Managers { get; set; }
        public virtual ICollection<OverworkBasicData> OverworkBasicData { get; set; }
        public virtual ICollection<ShiftPersonnel> ShiftPersonnel { get; set; }
        public virtual ICollection<SoftwareVersion> SoftwareVersion { get; set; }
        public virtual ICollection<SpecialPersonnel> SpecialPersonnel { get; set; }
        public virtual ICollection<Units> Units { get; set; }
        public virtual ICollection<UserUnits> UserUnits { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
