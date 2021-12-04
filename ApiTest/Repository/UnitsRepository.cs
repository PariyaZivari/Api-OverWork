using ApiTest.Models;
using Microsoft.EntityFrameworkCore;
using OverWorkApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverWorkApi.Repository
{
    public class UnitsRepository : IUnitsRepository
    {
        private OverworkDBContext _context;
        public UnitsRepository(OverworkDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Units> Getall()
        {
            return _context.Units.ToList();
        }

        public async Task<bool> IsExists(int unitcode)
        {
            return await _context.Units.AnyAsync(c => c.UnitCode == unitcode);
        }

        public async Task<Units> Add(Units units)
        {
            await _context.Units.AddAsync(units);
            await _context.SaveChangesAsync();
            return units;
        }

        public async Task<Units> Find(int unitcode)
        {

            return await _context.Units.SingleOrDefaultAsync(c => c.UnitCode == unitcode);
        }
        public async Task<Units> Remove(int unitcode)
        {
            var units = await _context.Units.SingleAsync(c => c.UnitCode == unitcode);
            _context.Units.Remove(units);
            await _context.SaveChangesAsync();
            return units;
        }

        public async Task<Units> Update(Units unit)
        {
            _context.Units.Update(unit);
            await _context.SaveChangesAsync();
            return unit;

        }

        public async Task<int> CountManager()
        {
            return await _context.Units.CountAsync();
        }
    }
}
