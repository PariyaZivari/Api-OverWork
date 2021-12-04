using ApiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverWorkApi.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<Users> Getall();
        Task<Users> Add(Users users);
        Task<Users> Find(string username);
        Task<Users> Update(Users users);
        Task<Users> Remove(string username);
        Task<bool> IsExists(string username);
    }
}
