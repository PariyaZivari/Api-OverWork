using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiTest.Models
{
    public partial class Managers
    {
        public int Id { get; set; }
        public int ManagerNo { get; set; }
        public string ManagerName { get; set; }
        public string ManagerFamily { get; set; }
        public int State { get; set; }
        public virtual RecordStates StateNavigation { get; set; }
    }
}
