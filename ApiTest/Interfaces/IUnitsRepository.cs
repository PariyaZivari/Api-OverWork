using ApiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverWorkApi.Interfaces
{
   public interface IUnitsRepository
    {
        IEnumerable<Units> Getall();
        Task<Units> Add(Units units);
        Task<Units> Find(int unitcode);
        Task<Units> Update(Units units);
        Task<Units> Remove(int unitcode);
        Task<bool> IsExists(int unitcode);
    }
}
