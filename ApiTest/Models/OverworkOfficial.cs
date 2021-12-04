using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class OverworkOfficial
    {
        public int Id { get; set; }
        public int OverworkMasterId { get; set; }
        public int Pno { get; set; }
        public string FullName { get; set; }
        public decimal Normale { get; set; }
        public decimal RealTotalOv { get; set; }
        public decimal EzafTp { get; set; }
        public decimal RealHolidayOvDouble { get; set; }
        public decimal EzafM { get; set; }
        public decimal EzafK { get; set; }
        public decimal EzafModiriat { get; set; }
        public decimal TotalHourPayment { get; set; }
        public decimal DiffRealAndBank { get; set; }
        public decimal DiffHolidayAndBank { get; set; }
        public decimal ManagerSuggest { get; set; }
        public decimal Shift { get; set; }
        public decimal TeleWork { get; set; }
        public decimal ManagerFinalConfirm { get; set; }
        public decimal FinalShift { get; set; }
        public decimal FinalTeleWork { get; set; }
        public string CommentsManager { get; set; }
        public string CommentsSeniorManager { get; set; }
        public decimal Fee { get; set; }
        public decimal TotalPricePayment { get; set; }
        public int UnitCode { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int UnitFilter { get; set; }

        public virtual OverworkMaster OverworkMaster { get; set; }
    }
}
