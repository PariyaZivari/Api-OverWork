using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class UserUnits
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int PersonnelTypeId { get; set; }
        public int UnitCode { get; set; }
        public int State { get; set; }

        public virtual PersonnelTypes PersonnelType { get; set; }
        public virtual RecordStates StateNavigation { get; set; }
        public virtual Units UnitCodeNavigation { get; set; }
        public virtual Users UsernameNavigation { get; set; }
    }
}
