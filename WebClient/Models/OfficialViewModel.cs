using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Models
{
    public class OfficialViewModel
    {
        public int Id { get; set; }
        public int Pno { get; set; }
        public string FullName { get; set; }
        public decimal Normale { get; set; }
        public decimal RealTotalOv { get; set; }
        public decimal EzafTp { get; set; }
        public decimal RealHolidayOvDouble { get; set; }
        public decimal EzafModiriat { get; set; }
        public decimal TotalHourPayment { get; set; }
        public int UnitCode { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }


    }
}
