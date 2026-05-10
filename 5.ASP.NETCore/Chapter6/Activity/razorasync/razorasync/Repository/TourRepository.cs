using razorasync.Interface;
using razorasync.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace razorasync.Repository
{
    
        public class TourRepository : ITourRepository
        {
        private readonly AppDbContext _context;
        public TourRepository(AppDbContext context)
        {
            _context = context;
           
        }

            public async Task<IEnumerable<Tour>> GetAllAsync() =>
                await _context.Tours.ToListAsync();

        public async Task<Tour> GetByIdAsync(int id)
        {
            return await _context.Tours.FindAsync(id);
        }

            public async Task AddAsync(Tour tour)
            {
                await _context.Tours.AddAsync(tour);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(Tour tour)
            {
                _context.Tours.Update(tour);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var tour = await _context.Tours.FindAsync(id);
                if (tour != null)
                {
                    _context.Tours.Remove(tour);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }


