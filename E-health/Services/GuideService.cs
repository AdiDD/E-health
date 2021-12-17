using E_health.Data;
using E_health.Models;
using E_health.Services.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_health.Services
{
    public class GuideService : IGuideService
    {
        private readonly ApplicationDbContext _db;

        public GuideService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<Guide> AddAsync(Guide item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Guide>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Guide> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Guide> UpdateAsync(Guide item)
        {
            throw new NotImplementedException();
        }
    }
}
