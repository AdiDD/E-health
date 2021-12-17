using E_health.Data;
using E_health.Models;
using E_health.Services.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_health.Services
{
    public class StepService : IStepService
    {
        private readonly ApplicationDbContext _db;

        public StepService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<Step> AddAsync(Step item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Step>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Step> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Step> UpdateAsync(Step item)
        {
            throw new NotImplementedException();
        }
    }
}
