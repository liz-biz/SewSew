using SewSew.Data;
using SewSew.Models;

namespace SewSew.Repositories
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly AppDbContext _dbContext;
        public MeasurementRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Measurement measurement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Measurement> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Measurement> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Measurement measurement)
        {
            throw new NotImplementedException();
        }
    }
}
