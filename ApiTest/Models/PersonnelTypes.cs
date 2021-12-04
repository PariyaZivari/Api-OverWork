using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class PersonnelTypes
    {
        public PersonnelTypes()
        {
            OverworkDates = new HashSet<OverworkDates>();
            ShiftPersonnel = new HashSet<ShiftPersonnel>();
            SpecialPersonnel = new HashSet<SpecialPersonnel>();
            UserUnits = new HashSet<UserUnits>();
        }

        public int Id { get; set; }
        public string PersonnelType { get; set; }

        public virtual ICollection<OverworkDates> OverworkDates { get; set; }
        public virtual ICollection<ShiftPersonnel> ShiftPersonnel { get; set; }
        public virtual ICollection<SpecialPersonnel> SpecialPersonnel { get; set; }
        public virtual ICollection<UserUnits> UserUnits { get; set; }
    }
}
