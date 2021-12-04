using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class OverworkBasicData
    {
        public int Id { get; set; }
        public decimal OverworkMaxHour { get; set; }
        public decimal HolidayMaxHour { get; set; }
        public decimal MaxHourPaymentBetweenFortyToFifty { get; set; }
        public decimal MaxHourPaymentOverFifty { get; set; }
        public decimal MaxHourDiffRealOverFifty { get; set; }
        public decimal PersonnelContractPartOnePercent { get; set; }
        public decimal MaxHourOnePersonnelContract { get; set; }
        public decimal OverworkMaxHourOnePersonnelContract { get; set; }
        public decimal MaxHourShiftContract { get; set; }
        public decimal MaxHourShiftOfficial { get; set; }
        public decimal MaxHourTeleWorkContract { get; set; }
        public decimal MaxHourTeleWorkOfficial { get; set; }
        public int State { get; set; }
        public string CreatedDate { get; set; }
        public decimal ExcludBudgetPrimary { get; set; }
        public decimal ExcludBudgetSecendery { get; set; }
        public decimal OverworkMaxContract { get; set; }
        public decimal OverworkExcludeMaxContract { get; set; }

        public virtual RecordStates StateNavigation { get; set; }
    }
}
