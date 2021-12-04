using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class OverworkContract
    {
        public int Id { get; set; }
        public int OverworkMasterId { get; set; }
        public int Pno { get; set; }
        public string FullName { get; set; }
        public decimal OverworkHour { get; set; }
        public decimal RealHolidayOvDouble { get; set; }
        public decimal SumM { get; set; }
        public decimal DiffOverworkMiss { get; set; }
        public int NumberAbsent { get; set; }
        public decimal ManagerSuggest { get; set; }
        public decimal Shift { get; set; }
        public decimal TeleWork { get; set; }
        public decimal ManagerFinalConfirm { get; set; }
        public decimal FinalShift { get; set; }
        public decimal FinalTeleWork { get; set; }
        public string CommentsManager { get; set; }
        public string CommentsSeniorManager { get; set; }
        public string ProvinceName { get; set; }
        public int UnitCode { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public decimal Karkard { get; set; }
        public decimal ExcludPrimaryManagerSuggest { get; set; }
        public decimal ExcludSecenderyManagerSuggest { get; set; }
        public decimal ExcludPrimaryFinalConfirm { get; set; }
        public decimal ManagerSuggestPercentTwo { get; set; }
        public int UnitFilter { get; set; }
        public decimal ManagreOverWorkDeduction { get; set; }

        public virtual OverworkMaster OverworkMaster { get; set; }
    }
}
