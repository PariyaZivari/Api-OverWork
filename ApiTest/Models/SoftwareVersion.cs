using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class SoftwareVersion
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public byte ImportantLevel { get; set; }
        public string UpdatePath { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public int State { get; set; }

        public virtual RecordStates StateNavigation { get; set; }
    }
}
