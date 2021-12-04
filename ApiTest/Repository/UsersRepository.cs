using ApiTest.Models;
using Microsoft.EntityFrameworkCore;
using OverWorkApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OverWorkApi.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private OverworkDBContext _context;
        public UsersRepository(OverworkDBContext context)
        {
            _context = context;
        }
     
        public IEnumerable<Users> Getall()
        {
            return _context.Users.ToList();
        }

        public async Task<bool> IsExists(string username)
        {
            return await _context.Users.AnyAsync(c => c.Username  == username);
        }

        public async Task<Users> Add(Users users)
        {
            await _context.Users.AddAsync(users);
            await _context.SaveChangesAsync();
            return users;
        }

        public async Task<Users> Find(string username)
        {

            return await _context.Users.SingleOrDefaultAsync(c => c.Username == username);
        }
        public async Task<Users> Remove(string username)
        {
            var users = await _context.Users.SingleAsync(c => c.Username == username);
            _context.Users.Remove(users);
            await _context.SaveChangesAsync();
            return users;
        }

        public async Task<Users> Update(Users users)
        {
            _context.Users.Update(users);
            await _context.SaveChangesAsync();
            return users;

        }

        public async Task<int> CountManager()
        {
            return await _context.Users.CountAsync();
        }
    }
}
