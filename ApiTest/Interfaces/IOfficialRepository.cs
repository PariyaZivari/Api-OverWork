using ApiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverWorkApi.Interfaces
{
    public interface IOfficialRepository
    {
        IEnumerable<OverworkOfficial> Getall();
        Task<OverworkOfficial> Add(OverworkOfficial official);
        Task<OverworkOfficial> Find(int id);
        Task<OverworkOfficial> Update(OverworkOfficial official);
        Task<OverworkOfficial> Remove(int id);
        Task<bool> IsExists(int id);
        
    }
}
