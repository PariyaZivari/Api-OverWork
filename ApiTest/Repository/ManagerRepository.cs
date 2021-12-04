
using ApiTest.Models;
using Microsoft.EntityFrameworkCore;
using OverWorkApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverWorkApi.Repository
{
    public class ManagerRepository : IManagersRepository
    {
        private OverworkDBContext _context;
        public ManagerRepository(OverworkDBContext context)
        {
            _context = context;
        }
        public async Task<Managers> Add(Managers managers)
        {
            await _context.Managers.AddAsync(managers);
            await _context.SaveChangesAsync();
            return managers;
        }

        public async Task<Managers> Find(int id)
        {

            return await _context.Managers.SingleOrDefaultAsync(c=>c.Id == id);
        }

        public  IEnumerable<Managers> Getall()
        {
            return  _context.Managers.ToList();
        }

        public async Task<bool> IsExists(int id)
        {
            return await _context.Managers.AnyAsync(c => c.Id == id);
        }

        public async Task<Managers> Remove(int id)
        {
            var manager = await _context.Managers.SingleAsync(c => c.Id == id);
            _context.Managers.Remove(manager);
            await _context.SaveChangesAsync();
            return manager;
        }

        public async  Task<Managers> Update(Managers managers)
        {
            _context.Managers.Update(managers);
            await _context.SaveChangesAsync();
            return managers;

        }

        public async Task<int> CountManager()
        {
            return await _context.Managers.CountAsync();
        }
    }
}
