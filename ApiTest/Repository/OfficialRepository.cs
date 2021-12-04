using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Models;
using Microsoft.EntityFrameworkCore;
using OverWorkApi.Interfaces;

namespace OverWorkApi.Repository
{
    public class OfficialRepository : IOfficialRepository
    {
        private OverworkDBContext _context;
        public OfficialRepository(OverworkDBContext context)
        {
            _context = context;
        }
        public async Task<OverworkOfficial> Add(OverworkOfficial official)
        {
            await _context.OverworkOfficial.AddAsync(official);
            await _context.SaveChangesAsync();
            return official;
        }

        public async Task<OverworkOfficial> Find(int id)
        {

            return await _context.OverworkOfficial.SingleOrDefaultAsync(c => c.Id == id);
        }

        public IEnumerable<OverworkOfficial> Getall()
        {
            return _context.OverworkOfficial.ToList();
        }

        public async Task<bool> IsExists(int id)
        {
            return await _context.OverworkOfficial.AnyAsync(c => c.Id == id);
        }

        public async Task<OverworkOfficial> Remove(int id)
        {
            var manager = await _context.OverworkOfficial.SingleAsync(c => c.Id == id);
            _context.OverworkOfficial.Remove(manager);
            await _context.SaveChangesAsync();
            return manager;
        }

        public async Task<OverworkOfficial> Update(OverworkOfficial official)
        {
            _context.OverworkOfficial.Update(official);
            await _context.SaveChangesAsync();
            return official;

        }

       
    }
}
