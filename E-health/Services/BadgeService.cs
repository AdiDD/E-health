using E_health.Data;
using E_health.Models;
using E_health.Services.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_health.Services
{
    public class BadgeService : IBadgeService
    {
        private readonly ApplicationDbContext _db;

        public BadgeService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<Badge> AddAsync(Badge item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Badge>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Badge> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Badge> UpdateAsync(Badge item)
        {
            throw new NotImplementedException();
        }
    }
}
