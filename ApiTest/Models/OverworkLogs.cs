using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class OverworkLogs
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public string EntityId { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
        public string CreatedDate { get; set; }
    }
}
