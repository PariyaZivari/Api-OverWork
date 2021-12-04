using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Models;

namespace OverWorkApi.Interfaces
{
    public interface IManagersRepository
    {
        IEnumerable<Managers> Getall();
        Task<Managers> Add(Managers managers);
        Task<Managers> Find(int id );
        Task<Managers> Update(Managers managers);
        Task<Managers> Remove(int id);
        Task<bool> IsExists(int id);
        Task<int> CountManager();
    }
}
